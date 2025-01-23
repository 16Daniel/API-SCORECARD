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

        public virtual DbSet<CatJob> CatJobs { get; set; } = null!;
        public virtual DbSet<JobsEjecutado> JobsEjecutados { get; set; } = null!;
        public virtual DbSet<Parametro> Parametros { get; set; } = null!;

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
            modelBuilder.Entity<CatJob>(entity =>
            {
                entity.ToTable("CAT_JOBS");

                entity.Property(e => e.Id).HasColumnName("ID");

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

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("PARAMETROS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
