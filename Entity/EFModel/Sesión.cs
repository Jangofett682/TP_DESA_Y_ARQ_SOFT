using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Sesión
{
    public int IdSesion { get; set; }

    public int JuegoId { get; set; }

    public int ServidorId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public decimal HorasReservadas { get; set; }

    public decimal MontoTotal { get; set; }

    public virtual Juego Juego { get; set; } = null!;

    public virtual Jugador NombreUsuarioNavigation { get; set; } = null!;

    public virtual Servidor Servidor { get; set; } = null!;
}
