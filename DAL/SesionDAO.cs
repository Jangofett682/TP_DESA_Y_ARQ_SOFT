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
        public List<SesionEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Sesión
                        .Include(s=>s.NombreUsuarioNavigation)
                        .Include(s=>s.Servidor)
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
                    Sesión sesion = db.Sesión
                        .FirstOrDefault(s => s.IdSesion == id);
                    if (sesion != null)
                    {
                        return SesionMapper.Map(sesion);
                    }
                    return null;
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
        public void Modificar(SesionEntity sesionModificada)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    //Compruebo si ya existe o no
                    Sesión sesion = db.Sesión.FirstOrDefault(s => s.IdSesion == sesionModificada.IdSesion);
                    if (sesion != null)
                    {
                        //Asigno nuevos valores y persisto						                    
                        sesion.JuegoId = sesionModificada.JuegoId;
                        sesion.ServidorId = sesionModificada.ServidorId;
                        sesion.HorasReservadas = Convert.ToDecimal(sesionModificada.HorasReservadas);
                        sesion.MontoTotal = Convert.ToDecimal(sesionModificada.MontoTotal);
                        db.SaveChanges();
                    }
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
