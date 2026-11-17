using DAL.Models;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Singleton
    public class SesionJugador
    {
        private static SesionJugador instancia;

        private string jugadorUsuario;
        private string nombreUsuario;

        private string email;
        private double saldoDisponible;

        public string JugadorUsuario { get => jugadorUsuario; set => jugadorUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Email { get => email; set => email = value; }
        public double SaldoDisponible { get => saldoDisponible; set => saldoDisponible = value; }

        public static SesionJugador GetInstance()
        {
            if(instancia == null)
            {
                instancia = new SesionJugador();
            }
            return instancia;
        }

        public void IniciarSesion(JugadorEntity jugador)
        {
            try
            {
                if(jugador != null)
                {
                    this.jugadorUsuario = jugador.NombreUsuario;
                    this.nombreUsuario = jugador.NombreApellido;
                    this.email = jugador.Mail;
                    this.saldoDisponible = jugador.SaldoDisponible;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void CerrarSesion()
        {
            try
            {
                jugadorUsuario = null;
                nombreUsuario = null;
                email = null;
                saldoDisponible = 0;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void ActualizarSaldoDisponible(double nuevoSaldo)
        {
            try
            {
                SaldoDisponible = nuevoSaldo;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
