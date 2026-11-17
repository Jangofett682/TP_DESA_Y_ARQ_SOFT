using DAL.Models;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class JugadorMapper
    {
        public static JugadorEntity Map(Jugador jugador)
        {
            try
            {
                return new JugadorEntity
                {
                    NombreUsuario = jugador.NombreUsuario,
                    NombreApellido = jugador.NombreUsuario,
                    Mail = jugador.Mail,
                    SaldoDisponible = Convert.ToDouble(jugador.SaldoDisponible),
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Jugador Map(JugadorEntity jugador)
        {
            try
            {
                return new Jugador
                {
                    NombreUsuario = jugador.NombreUsuario,
                    NombreApellido = jugador.NombreApellido,
                    Mail = jugador.Mail,
                    SaldoDisponible = Convert.ToDecimal(jugador.SaldoDisponible),
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Mappeo de listas
        public static List<JugadorEntity> Map(List<Jugador> listaJugadores)
        {
            if (listaJugadores == null)
            {
                return new List<JugadorEntity>();
            }
            return listaJugadores.Select(j => Map(j)).ToList();
        }

        public static List<Jugador> MapBD(List<JugadorEntity> listaJugadores)
        {
            if (listaJugadores == null)
            {
                return new List<Jugador>();
            }
            return listaJugadores.Select(j => Map(j)).ToList();
        }
    }
}
