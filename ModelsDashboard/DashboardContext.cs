using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DashboardApi.ModelsDashboard
{
    public partial class DashboardContext : DbContext
    {
        public DashboardContext()
        {
        }

        public DashboardContext(DbContextOptions<DashboardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccesosRuta> AccesosRutas { get; set; } = null!;
        public virtual DbSet<CatJob> CatJobs { get; set; } = null!;
        public virtual DbSet<CatRole> CatRoles { get; set; } = null!;
        public virtual DbSet<CatRuta> CatRutas { get; set; } = null!;
        public virtual DbSet<Diferencia> Diferencias { get; set; } = null!;
        public virtual DbSet<GruposSucursal> GruposSucursals { get; set; } = null!;
        public virtual DbSet<JobsEjecutado> JobsEjecutados { get; set; } = null!;
        public virtual DbSet<MetasSalon> MetasSalons { get; set; } = null!;
        public virtual DbSet<Parametro> Parametros { get; set; } = null!;
        public virtual DbSet<ReportesBono> ReportesBonos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.31.52;Initial Catalog=DashboardDB;Integrated Security=False;User Id=App2;Password=eVPUh82pWdSP9fPD;MultipleActiveResultSets=True;Connection Timeout=120000");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccesosRuta>(entity =>
            {
                entity.ToTable("ACCESOS_RUTAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

                entity.Property(e => e.IdRuta).HasColumnName("ID_RUTA");
            });

            modelBuilder.Entity<CatJob>(entity =>
            {
                entity.ToTable("CAT_JOBS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<CatRole>(entity =>
            {
                entity.ToTable("CAT_ROLES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<CatRuta>(entity =>
            {
                entity.ToTable("CAT_RUTAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Icon).HasColumnName("ICON");

                entity.Property(e => e.Ruta).HasColumnName("RUTA");
            });

            modelBuilder.Entity<Diferencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DIFERENCIAS");

                entity.Property(e => e.Articulo)
                    .IsUnicode(false)
                    .HasColumnName("ARTICULO");

                entity.Property(e => e.Cod)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("COD");

                entity.Property(e => e.Codart).HasColumnName("CODART");

                entity.Property(e => e.Diferencia1)
                    .IsUnicode(false)
                    .HasColumnName("DIFERENCIA");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.InvAyer)
                    .IsUnicode(false)
                    .HasColumnName("INV_AYER");

                entity.Property(e => e.InvFormula)
                    .IsUnicode(false)
                    .HasColumnName("INV_FORMULA");

                entity.Property(e => e.InvHoy)
                    .IsUnicode(false)
                    .HasColumnName("INV_HOY");

                entity.Property(e => e.Region)
                    .IsUnicode(false)
                    .HasColumnName("REGION");

                entity.Property(e => e.Semana).HasColumnName("SEMANA");

                entity.Property(e => e.Sucursal)
                    .IsUnicode(false)
                    .HasColumnName("SUCURSAL");
            });

            modelBuilder.Entity<GruposSucursal>(entity =>
            {
                entity.ToTable("GRUPOS_SUCURSAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<JobsEjecutado>(entity =>
            {
                entity.ToTable("JOBS_EJECUTADOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.IdJob).HasColumnName("ID_JOB");
            });

            modelBuilder.Entity<MetasSalon>(entity =>
            {
                entity.ToTable("METAS_SALON");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Meta).HasColumnName("META");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(50)
                    .HasColumnName("SUCURSAL");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("PARAMETROS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");
            });

            modelBuilder.Entity<ReportesBono>(entity =>
            {
                entity.ToTable("REPORTES_BONOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Ids).HasColumnName("IDS");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");

                entity.Property(e => e.Mes).HasColumnName("MES");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApellidoM)
                    .HasMaxLength(255)
                    .HasColumnName("APELLIDO_M");

                entity.Property(e => e.ApellidoP)
                    .HasMaxLength(250)
                    .HasColumnName("APELLIDO_P");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Pass).HasColumnName("PASS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
