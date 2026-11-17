using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class JugadorBusiness
    {
        JugadorDAO jugadorDAO = new JugadorDAO();
        public List<JugadorEntity> GetAll()
        {
            try
            {
                List<JugadorEntity> listaJugadores = jugadorDAO.getAll();
                return listaJugadores;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Agregar(JugadorEntity nuevoJugador)
        {
            try
            {
                if (string.IsNullOrEmpty(nuevoJugador.NombreUsuario) || string.IsNullOrEmpty(nuevoJugador.Mail))
                {
                    throw new Exception("El nombre de usuario/mail es obligatorio");
                }
                var existeUsuario = jugadorDAO.Autenticar(nuevoJugador.NombreUsuario);
                if(existeUsuario != null)
                {
                    throw new Exception($"El usuario {nuevoJugador.NombreUsuario} ya se encuentra registrado");
                }
                jugadorDAO.Guardar(nuevoJugador);
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
                if (string.IsNullOrEmpty(nombreUsuario))
                {
                    throw new Exception("Por favor ingresa un nombre de usuario");
                }
                //Consulta a DAL
                JugadorEntity jugador = jugadorDAO.Autenticar(nombreUsuario);

                if(jugador == null)
                {
                    throw new Exception("El usuario ingresado no existe");
                }
                return jugador;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void CargarSaldo(string nombreUsuario, double montoACargar)
        {
            try
            {
                if (montoACargar <= 0)
                {
                    throw new Exception("Por favor ingrese un monto mayor a 0");
                }
                JugadorEntity jugador = jugadorDAO.Autenticar(nombreUsuario);
                if(jugador == null)
                {
                    throw new Exception("No se encontró al jugador");
                }
                double nuevoSaldo = jugador.SaldoDisponible + montoACargar;
                jugadorDAO.ActualizarSaldo(nombreUsuario, nuevoSaldo);
                SesionJugador.GetInstance().ActualizarSaldoDisponible(nuevoSaldo);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
