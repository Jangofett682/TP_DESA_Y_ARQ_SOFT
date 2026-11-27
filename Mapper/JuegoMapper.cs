using DAL.Models;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mapper
{
    public class JuegoMapper
    {
        public static JuegoEntity Map(Juego juego)
        {
            try
            {
                if (juego == null)
                {
                    throw new ArgumentNullException(nameof(juego));
                }
                return new JuegoEntity
                {
                    IdJuego = juego.IdJuego,
                    Titulo = juego.Titulo,
                    Resolucion = juego.Resolucion,
                    Configuracion = juego.Configuracion,
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Juego Map(JuegoEntity juego)
        {
            try
            {
                if (juego == null)
                {
                    throw new ArgumentNullException(nameof(juego));
                }
                return new Juego
                {
                    IdJuego = juego.IdJuego,
                    Titulo = juego.Titulo,
                    Resolucion = juego.Resolucion,
                    Configuracion = juego.Configuracion
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Mappeo de listas
        public static List<JuegoEntity> Map(List<Juego> listaJuegos)
        {
            if (listaJuegos == null)
            {
                return new List<JuegoEntity>();
            }
            return listaJuegos.Select(j => Map(j)).ToList();
        }

        public static List<Juego> MapBD(List<JuegoEntity> listaJuegos)
        {
            if (listaJuegos == null)
            {
                return new List<Juego>();
            }
            return listaJuegos.Select(j => Map(j)).ToList();
        }
    }
}
