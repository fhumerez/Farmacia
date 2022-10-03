using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Farmacia
{
    public partial class FarmaciaContext : DbContext
    {
        public FarmaciaContext()
        {
        }

        public FarmaciaContext(DbContextOptions<FarmaciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DetalleVentum> DetalleVenta { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Farmaceutico> Farmaceuticos { get; set; } = null!;
        public virtual DbSet<Medicamento> Medicamentos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseSqlServer("Data Source=LAPTOP-DSG8LNIQ\\SQLSERVER_FER;Initial Catalog=Farmacia; User=sa; Password=123456");
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appconfig.json");
                var conf = builder.Build();
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(conf["ConnectionStrings:miConexion"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Nit);

                entity.ToTable("cliente");

                entity.Property(e => e.Nit)
                    .ValueGeneratedNever()
                    .HasColumnName("nit");

                entity.Property(e => e.ApellidoCliente)
                    .HasMaxLength(50)
                    .HasColumnName("apellidoCliente");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .HasColumnName("nombreCliente");
            });

            modelBuilder.Entity<DetalleVentum>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("detalleVenta");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodMedic)
                    .HasMaxLength(10)
                    .HasColumnName("codMedic")
                    .IsFixedLength();

                entity.Property(e => e.NumFactura).HasColumnName("numFactura");

                entity.HasOne(d => d.CodMedicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodMedic)
                    .HasConstraintName("FK_detalleVenta_medicamento");

                entity.HasOne(d => d.NumFacturaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NumFactura)
                    .HasConstraintName("FK_detalleVenta_factura");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.NumFactura);

                entity.ToTable("factura");

                entity.Property(e => e.NumFactura).HasColumnName("numFactura");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Nit).HasColumnName("nit");

                entity.HasOne(d => d.CiNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.Ci)
                    .HasConstraintName("FK_factura_farmaceutico");

                entity.HasOne(d => d.NitNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.Nit)
                    .HasConstraintName("FK_factura_cliente");
            });

            modelBuilder.Entity<Farmaceutico>(entity =>
            {
                entity.HasKey(e => e.Ci);

                entity.ToTable("farmaceutico");

                entity.Property(e => e.Ci)
                    .ValueGeneratedNever()
                    .HasColumnName("ci");

                entity.Property(e => e.ApellidoFarm)
                    .HasMaxLength(50)
                    .HasColumnName("apellidoFarm");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .HasColumnName("cargo");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .HasColumnName("contrasena");

                entity.Property(e => e.NombreFarm)
                    .HasMaxLength(50)
                    .HasColumnName("nombreFarm");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Medicamento>(entity =>
            {
                entity.HasKey(e => e.CodMed);

                entity.ToTable("medicamento");

                entity.Property(e => e.CodMed)
                    .HasMaxLength(10)
                    .HasColumnName("codMed")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaExp)
                    .HasColumnType("date")
                    .HasColumnName("fechaExp");

                entity.Property(e => e.NombreMedic)
                    .HasMaxLength(50)
                    .HasColumnName("nombreMedic");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
