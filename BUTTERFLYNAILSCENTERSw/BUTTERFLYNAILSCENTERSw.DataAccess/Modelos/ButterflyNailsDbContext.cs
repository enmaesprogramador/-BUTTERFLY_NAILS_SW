using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class ButterflyNailsDbContext : DbContext
{
    const string conString = "server=localhost;port=3306;database=BUTTERFLY_NAILS_DB;user=root;password=*-.3nM4Nu310202.-*";
    public ButterflyNailsDbContext()
    {
    }

    public ButterflyNailsDbContext(DbContextOptions<ButterflyNailsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Metodosdepago> Metodosdepagos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Ventaservicio> Ventaservicios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(conString, MySqlServerVersion.AutoDetect(conString));
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("citas");

            entity.HasIndex(e => e.ClienteId, "ClienteId");

            entity.HasIndex(e => e.ServicioId, "ServicioId");

            entity.Property(e => e.Fecha);
            entity.Property(e => e.Status);
            entity.Property(e => e.FechaDeRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Cita)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("citas_ibfk_1");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Cita)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("citas_ibfk_2");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.FechaDeRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NumeroDeTelefono).HasMaxLength(10);
        });

        modelBuilder.Entity<Metodosdepago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("metodosdepago");

            entity.Property(e => e.FechaDeRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("servicios");

            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Rol).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<Ventaservicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ventaservicio");

            entity.HasIndex(e => e.CitaId, "CitaId");

            entity.HasIndex(e => e.ClienteId, "ClienteId");

            entity.HasIndex(e => e.MetodoPagoId, "MetodoPagoId");

            entity.HasIndex(e => e.ServicioId, "ServicioId");

            entity.Property(e => e.FechaDeRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
          

            entity.HasOne(d => d.Cita).WithMany(p => p.Ventaservicios)
                .HasForeignKey(d => d.CitaId)
                .HasConstraintName("ventaservicio_ibfk_4");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Ventaservicios)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ventaservicio_ibfk_2");

            entity.HasOne(d => d.MetodoPago).WithMany(p => p.Ventaservicios)
                .HasForeignKey(d => d.MetodoPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ventaservicio_ibfk_3");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Ventaservicios)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ventaservicio_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
