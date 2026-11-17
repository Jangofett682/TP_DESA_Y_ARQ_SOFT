using DAL.Models;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JugadorDAO
    {
        public List<JugadorEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Jugador
                        .ToList();
                    return JugadorMapper.Map(listaDB);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Guardar(JugadorEntity jugador)
        {
            try
            {
                using(var db = new CloudGamingContext())
                {
                    var jugadorBD = JugadorMapper.Map(jugador);

                    db.Jugador.Add(jugadorBD);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        
        public JugadorEntity Autenticar(string nombreUsuario)
        {
            try
            {
                using(var db = new CloudGamingContext())
                {
                    var jugadorBD = db.Jugador
                        .FirstOrDefault(j => j.NombreUsuario == nombreUsuario);
                    return JugadorMapper.Map(jugadorBD);
                        
                }
            }
            catch(Exception ex)
            {

                throw;
            }
        }

        public void ActualizarSaldo(string nombreUsuario, double nuevoSaldo)
        {
            try
            {
                using(var db = new CloudGamingContext())
                {
                    var jugadorBD = db.Jugador
                        .FirstOrDefault(j => j.NombreUsuario == nombreUsuario);
                    if (jugadorBD != null)
                    {
                        jugadorBD.SaldoDisponible = Convert.ToDecimal(nuevoSaldo);
                        db.SaveChanges();
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
