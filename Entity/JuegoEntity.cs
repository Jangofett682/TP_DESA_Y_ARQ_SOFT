using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class JuegoEntity
    {
        private int idJuego;
        private string titulo;
        private string resolucion;
        private string configuracion;

        public int IdJuego { get => idJuego; set => idJuego = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Resolucion { get => resolucion; set => resolucion = value; }
        public string Configuracion { get => configuracion; set => configuracion = value; }
        public int CostoPuntos { get; set; }
    }
}
