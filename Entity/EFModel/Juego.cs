using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Juego
{
    public int IdJuego { get; set; }

    public string Titulo { get; set; } = null!;

    public string Resolucion { get; set; } = null!;

    public string Configuracion { get; set; } = null!;

    public virtual ICollection<Sesión> Sesión { get; set; } = new List<Sesión>();
}
