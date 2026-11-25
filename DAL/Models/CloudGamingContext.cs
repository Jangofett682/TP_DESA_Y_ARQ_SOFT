using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DAL.Models;

public partial class CloudGamingContext : DbContext
{
    public CloudGamingContext()
    {
    }

    public CloudGamingContext(DbContextOptions<CloudGamingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Juego> Juego { get; set; }

    public virtual DbSet<Jugador> Jugador { get; set; }

    public virtual DbSet<Servidor> Servidor { get; set; }

    public virtual DbSet<Sesión> Sesión { get; set; }

    public static void EjecutarTransaccion(Action<CloudGamingContext> operacion)
    {
        for (int intento = 0; ; intento++)
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    using var transaccion = db.Database.BeginTransaction(IsolationLevel.Serializable);
                    operacion(db);
                    transaccion.Commit();
                    return;
                }
            }
            catch (Exception ex) when (intento < 3 && ex.GetBaseException() is SqlException { Number: 1205 })
            {
                // La base revirtió esta transacción. Volvemos a intentar con otro contexto.
            }
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(DBConfigurations.GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Juego>(entity =>
        {
            entity.HasKey(e => e.IdJuego);

            entity.Property(e => e.IdJuego).HasColumnName("ID_JUEGO");
            entity.Property(e => e.Configuracion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONFIGURACION");
            entity.Property(e => e.Resolucion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RESOLUCION");
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITULO");
        });

        modelBuilder.Entity<Jugador>(entity =>
        {
            entity.HasKey(e => e.NombreUsuario);

            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAIL");
            entity.Property(e => e.NombreApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_APELLIDO");
            entity.Property(e => e.SaldoDisponible)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SALDO_DISPONIBLE");
        });

        modelBuilder.Entity<Servidor>(entity =>
        {
            entity.HasKey(e => e.IdServidor);

            entity.Property(e => e.IdServidor).HasColumnName("ID_SERVIDOR");
            entity.Property(e => e.Cpu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPU");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Gpu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GPU");
            entity.Property(e => e.PrecioHora)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PRECIO_HORA");
            entity.Property(e => e.Ram)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RAM");
        });

        modelBuilder.Entity<Sesión>(entity =>
        {
            entity.HasKey(e => e.IdSesion);
            entity.HasIndex(e => new { e.ServidorId, e.FinUtc }, "IX_Sesion_Servidor_FinUtc");

            entity.Property(e => e.IdSesion).HasColumnName("ID_SESION");
            entity.Property(e => e.InicioUtc).HasColumnName("INICIO_UTC");
            entity.Property(e => e.FinUtc).HasColumnName("FIN_UTC");
            entity.Property(e => e.PuntosConsumidos).HasColumnName("PUNTOS_CONSUMIDOS");
            entity.Property(e => e.HorasReservadas)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HORAS_RESERVADAS");
            entity.Property(e => e.JuegoId).HasColumnName("JUEGO_ID");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MONTO_TOTAL");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_USUARIO");
            entity.Property(e => e.ServidorId).HasColumnName("SERVIDOR_ID");

            entity.HasOne(d => d.Juego).WithMany(p => p.Sesión)
                .HasForeignKey(d => d.JuegoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sesión_Juego");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithMany(p => p.Sesión)
                .HasForeignKey(d => d.NombreUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sesión_Jugador");

            entity.HasOne(d => d.Servidor).WithMany(p => p.Sesión)
                .HasForeignKey(d => d.ServidorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sesión_Servidor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
