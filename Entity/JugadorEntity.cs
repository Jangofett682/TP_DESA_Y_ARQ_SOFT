using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class JugadorEntity
    {
        private string nombreUsuario;
        private string nombreApellido;
        private string mail;
        private double saldoDisponible;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public double SaldoDisponible { get => saldoDisponible; set => saldoDisponible = value; }
    }
}
