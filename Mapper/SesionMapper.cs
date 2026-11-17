using DAL.Models;
using Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class SesionMapper
    {
        public static SesionEntity Map(Sesión sesion)
        {
            try
            {
                return new SesionEntity
                {
                    IdSesion = sesion.IdSesion,
                    JuegoId = sesion.JuegoId,
                    ServidorId = sesion.ServidorId,
                    NombreUsuario = sesion.NombreUsuario,
                    HorasReservadas = Convert.ToDouble(sesion.HorasReservadas),
                    MontoTotal = Convert.ToDouble(sesion.MontoTotal),
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Sesión Map(SesionEntity sesion)
        {
            try
            {
                return new Sesión
                {
                    IdSesion = sesion.IdSesion,
                    JuegoId = sesion.JuegoId,
                    ServidorId = sesion.ServidorId,
                    NombreUsuario = sesion.NombreUsuario,
                    HorasReservadas = Convert.ToDecimal(sesion.HorasReservadas),
                    MontoTotal = Convert.ToDecimal(sesion.MontoTotal),
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Mappeo de listas
        public static List<SesionEntity> Map(List<Sesión> listaSesiones)
        {
            if (listaSesiones == null)
            {
                return new List<SesionEntity>();
            }
            return listaSesiones.Select(s => Map(s)).ToList();
        }

        public static List<Sesión> MapBD(List<SesionEntity> listaSesiones)
        {
            if (listaSesiones == null)
            {
                return new List<Sesión>();
            }
            return listaSesiones.Select(s => Map(s)).ToList();
        }
    }
}
