using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Servidor
{
    public int IdServidor { get; set; }

    public string Gpu { get; set; } = null!;

    public string Cpu { get; set; } = null!;

    public string Ram { get; set; } = null!;

    public decimal PrecioHora { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<Sesión> Sesión { get; set; } = new List<Sesión>();
}
