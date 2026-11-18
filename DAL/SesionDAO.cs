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
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = SesionMapper.MapBD(listaSesiones);

                    foreach (var sesionBD in listaDB)
                    {
                        db.Sesión.Add(sesionBD);
                    }

                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void RegistrarSesionSaldo(SesionEntity sesion, double nuevoSaldo)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    using (var db = new CloudGamingContext())
                    {
                        var nuevaSesionBD = SesionMapper.Map(sesion);
                        db.Sesión.Add(nuevaSesionBD);

                        //Actualización saldo
                        var jugadorBD = db.Jugador
                            .FirstOrDefault(j => j.NombreUsuario == sesion.NombreUsuario);
                        if (jugadorBD != null)
                        {
                            jugadorBD.SaldoDisponible = Convert.ToDecimal(nuevoSaldo);
                        }
                        db.SaveChanges();
                    }
                    trx.Complete();
                }
            }
            catch(Exception ex)
            {
                throw;
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

        //Método Modificar, SesionEntity como parámetro
        public void Modificar(SesionEntity sesionModificada, double nuevoSaldo)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    using (var db = new CloudGamingContext())
                    {
                        var sesionBD = db.Sesión.FirstOrDefault(s => s.IdSesion == sesionModificada.IdSesion);
                        if(sesionBD != null)
                        {
                            sesionBD.HorasReservadas = Convert.ToDecimal(sesionModificada.HorasReservadas);
                            sesionBD.MontoTotal = Convert.ToDecimal(sesionModificada.MontoTotal);
                        }
                        var jugadorBD = db.Jugador.FirstOrDefault(j => j.NombreUsuario == sesionModificada.NombreUsuario);
                        if (jugadorBD != null)
                        {
                            jugadorBD.SaldoDisponible = Convert.ToDecimal(nuevoSaldo);
                        }
                        db.SaveChanges();
                    }
                    trx.Complete();
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
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
