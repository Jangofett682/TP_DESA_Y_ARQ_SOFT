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
                if(sesion == null)
                {
                    return null;
                }
                double horas = Convert.ToDouble(sesion.HorasReservadas);
                double montoTotal = Convert.ToDouble(sesion.MontoTotal);
                double precioHora = sesion.Servidor != null ? Convert.ToDouble(sesion.Servidor.PrecioHora) : 0.0;

                double total = horas * precioHora;
                double descuento = 0.0;
                if(total > 0 && montoTotal < total)
                {
                    descuento = Math.Round(((total-montoTotal)/total)*100,2);
                }
                else
                {
                    descuento = CalcularPorcentajeHoras(horas);
                }

                return new SesionEntity
                {
                    IdSesion = sesion.IdSesion,
                    JuegoId = sesion.JuegoId,
                    ServidorId = sesion.ServidorId,
                    NombreUsuario = sesion.NombreUsuario,
                    HorasReservadas = Convert.ToDouble(sesion.HorasReservadas),
                    MontoTotal = Convert.ToDouble(sesion.MontoTotal),

                    PrecioHoraServidor = sesion.Servidor != null
                    ? Convert.ToDouble(sesion.Servidor.PrecioHora)
                    : 0.0,

                    PorcentajeDescuento = descuento,
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static double CalcularPorcentajeHoras(double horas)
        {
            try
            {
                if (horas >= 10)
                {
                    return 20.0;
                }
                if(horas >= 5)
                {
                    return 10.0;
                }
                return 0.0;
            }
            catch(Exception ex)
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
