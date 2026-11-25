using Azure.Messaging;
using DAL.Models;
using Entity;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class SesionDAO
    {
        public ServidorDAO servidorDAO = new ServidorDAO();
        public List<SesionEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Sesión
                        .Include(s=>s.NombreUsuarioNavigation)
                        .Include(s=>s.Servidor)
                        .Include(s=>s.Juego)
                        .ToList();
                    return SesionMapper.Map(listaDB);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Alta de varias sesiones
        public void AltaConjunta(List<SesionEntity> listaSesiones)
        {
            CloudGamingContext.EjecutarTransaccion(db =>
            {
                foreach (var sesion in listaSesiones)
                {
                    var sesionBD = SesionMapper.Map(sesion);
                    RegistrarCapacidad(db, sesion, sesionBD);
                    db.Sesión.Add(sesionBD);
                    db.SaveChanges();
                }
            });
        }

        public void RegistrarSesionSaldo(SesionEntity sesion, double nuevoSaldo)
        {
            CloudGamingContext.EjecutarTransaccion(db =>
            {
                var nuevaSesionBD = SesionMapper.Map(sesion);
                RegistrarCapacidad(db, sesion, nuevaSesionBD);

                var jugadorBD = db.Jugador.FirstOrDefault(j => j.NombreUsuario == sesion.NombreUsuario);
                if (jugadorBD != null)
                {
                    decimal saldo = Convert.ToDecimal(nuevoSaldo);
                    if (nuevaSesionBD.PuntosConsumidos.HasValue)
                    {
                        decimal monto = decimal.Round(nuevaSesionBD.MontoTotal, 0, MidpointRounding.AwayFromZero);
                        saldo = jugadorBD.SaldoDisponible - monto;
                        if (saldo < 0)
                        {
                            throw new InvalidOperationException("Saldo insuficiente para alquilar servidor");
                        }
                        nuevaSesionBD.MontoTotal = monto;
                    }
                    jugadorBD.SaldoDisponible = saldo;
                }

                db.Sesión.Add(nuevaSesionBD);
                db.SaveChanges();
            });
        }

        private void RegistrarCapacidad(CloudGamingContext db, SesionEntity sesion, Sesión sesionBD)
        {
            if (!sesion.PuntosConsumidos.HasValue)
            {
                return;
            }

            DateTime inicio = DateTime.UtcNow;
            DateTime fin = inicio.AddHours(sesion.HorasReservadas);
            ValidarPuntos(db, sesionBD, inicio, fin, sesion.CapacidadPuntosServidor);
            sesionBD.InicioUtc = inicio;
            sesionBD.FinUtc = fin;
        }

        private void ValidarPuntos(CloudGamingContext db, Sesión sesion, DateTime inicio, DateTime fin, int capacidad)
        {
            int puntosOcupados = db.Sesión
                .Where(s => s.ServidorId == sesion.ServidorId && s.IdSesion != sesion.IdSesion
                    && s.InicioUtc < fin && s.FinUtc > inicio)
                .Sum(s => s.PuntosConsumidos) ?? 0;

            if (puntosOcupados + sesion.PuntosConsumidos.GetValueOrDefault() > capacidad)
            {
                throw new InvalidOperationException("El servidor no tiene puntos libres suficientes");
            }
        }

        //Método BuscarPorID, devuelve SesionEntity
        public SesionEntity BuscarPorID(int id)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    Sesión sesionBD = db.Sesión
                        .Include(s => s.Servidor)
                        .FirstOrDefault(s => s.IdSesion == id);
                    return sesionBD != null ? SesionMapper.Map(sesionBD) : null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Método eliminar, id como parámetro
        public void Eliminar(int id)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    Sesión sesion = db.Sesión.FirstOrDefault(s => s.IdSesion == id);

                    if (sesion != null)
                    {
                        db.Sesión.Remove(sesion);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Método Modificar, id como parámetro
        public void Modificar(SesionEntity sesionModificada, double nuevoSaldo)
        {
            CloudGamingContext.EjecutarTransaccion(db =>
            {
                var sesionBD = db.Sesión.FirstOrDefault(s => s.IdSesion == sesionModificada.IdSesion)
                    ?? throw new InvalidOperationException("La sesión no existe");
                var jugadorBD = db.Jugador.FirstOrDefault(j => j.NombreUsuario == sesionBD.NombreUsuario);
                decimal monto = Convert.ToDecimal(sesionModificada.MontoTotal);
                decimal saldo = Convert.ToDecimal(nuevoSaldo);

                if (sesionBD.InicioUtc is DateTime inicio && sesionBD.FinUtc is DateTime finAnterior)
                {
                    if (finAnterior <= DateTime.UtcNow)
                    {
                        throw new InvalidOperationException("La reserva ya terminó");
                    }

                    DateTime fin = inicio.AddHours(sesionModificada.HorasReservadas);
                    if (fin > finAnterior)
                    {
                        ValidarPuntos(db, sesionBD, finAnterior, fin, sesionModificada.CapacidadPuntosServidor);
                    }
                    sesionBD.FinUtc = fin;

                    monto = decimal.Round(monto, 0, MidpointRounding.AwayFromZero);
                    if (jugadorBD != null)
                    {
                        saldo = jugadorBD.SaldoDisponible - (monto - sesionBD.MontoTotal);
                        if (saldo < 0)
                        {
                            throw new InvalidOperationException("Saldo insuficiente para ampliar la reserva");
                        }
                    }
                }

                sesionBD.HorasReservadas = Convert.ToDecimal(sesionModificada.HorasReservadas);
                sesionBD.MontoTotal = monto;
                if (jugadorBD != null)
                {
                    jugadorBD.SaldoDisponible = saldo;
                }
                db.SaveChanges();
            });
        }

        public List<SesionEntity>ObtenerPorUsuario(string nombreUsuario)
        {
            try
            {
                using(var db = new CloudGamingContext())
                {
                    var sesionesBD = db.Sesión
                        .Include(s => s.Servidor)
                        .Where(s => s.NombreUsuario == nombreUsuario)
                        .ToList();
                    return sesionesBD.Select(s => SesionMapper.Map(s)).ToList();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
