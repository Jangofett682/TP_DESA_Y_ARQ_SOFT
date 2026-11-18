using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SesionEntity
    {
        private int idSesion;
        private int juegoId;
        private int servidorId;
        private string nombreUsuario;
        private double horasReservadas;
        private double montoTotal;

        public int IdSesion { get => idSesion; set => idSesion = value; }
        public int JuegoId { get => juegoId; set => juegoId = value; }
        public int ServidorId { get => servidorId; set => servidorId = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public double HorasReservadas { get => horasReservadas; set => horasReservadas = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }

        //Propiedades auxiliares
        public double PrecioHoraServidor { get; set; }
        public double PorcentajeDescuento { get; set; }

    }
}
