using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Jugador
{
    public string NombreUsuario { get; set; } = null!;

    public string NombreApellido { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public decimal SaldoDisponible { get; set; }

    public virtual ICollection<Sesión> Sesión { get; set; } = new List<Sesión>();
}
