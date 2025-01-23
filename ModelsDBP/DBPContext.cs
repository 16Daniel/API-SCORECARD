using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DashboardApi.ModelsDBP
{
    public partial class DBPContext : DbContext
    {
        public DBPContext()
        {
        }

        public DBPContext(DbContextOptions<DBPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccesosRuta> AccesosRutas { get; set; } = null!;
        public virtual DbSet<Almacenaje> Almacenajes { get; set; } = null!;
        public virtual DbSet<ArticulosProveedor> ArticulosProveedors { get; set; } = null!;
        public virtual DbSet<AsignacionProv> AsignacionProvs { get; set; } = null!;
        public virtual DbSet<Calendario> Calendarios { get; set; } = null!;
        public virtual DbSet<CalendariosChecada> CalendariosChecadas { get; set; } = null!;
        public virtual DbSet<CatRole> CatRoles { get; set; } = null!;
        public virtual DbSet<CatRuta> CatRutas { get; set; } = null!;
        public virtual DbSet<CatStatusChecada> CatStatusChecadas { get; set; } = null!;
        public virtual DbSet<Descuento> Descuentos { get; set; } = null!;
        public virtual DbSet<DiasEspeciale> DiasEspeciales { get; set; } = null!;
        public virtual DbSet<DiasEspecialesSucursal> DiasEspecialesSucursals { get; set; } = null!;
        public virtual DbSet<InventarioTeorico> InventarioTeoricos { get; set; } = null!;
        public virtual DbSet<LogDiferencia> LogDiferencias { get; set; } = null!;
        public virtual DbSet<Modificacione> Modificaciones { get; set; } = null!;
        public virtual DbSet<Notificacione> Notificaciones { get; set; } = null!;
        public virtual DbSet<Parametro> Parametros { get; set; } = null!;
        public virtual DbSet<PedSucArticulo> PedSucArticulos { get; set; } = null!;
        public virtual DbSet<PedSucProveedore> PedSucProveedores { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<PedidosSucursale> PedidosSucursales { get; set; } = null!;
        public virtual DbSet<Retornable> Retornables { get; set; } = null!;
        public virtual DbSet<Sesione> Sesiones { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuariosSucursal> UsuariosSucursals { get; set; } = null!;
        public virtual DbSet<ValidacionPedido> ValidacionPedidos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.31.52;Initial Catalog=DBP;Integrated Security=False;User Id=App2;Password=eVPUh82pWdSP9fPD;MultipleActiveResultSets=True;Connection Timeout=120000");
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

            modelBuilder.Entity<Almacenaje>(entity =>
            {
                entity.ToTable("ALMACENAJE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Capacidad).HasColumnName("CAPACIDAD");

                entity.Property(e => e.Codarticulo).HasColumnName("CODARTICULO");

                entity.Property(e => e.Idsucursal).HasColumnName("IDSUCURSAL");
            });

            modelBuilder.Entity<ArticulosProveedor>(entity =>
            {
                entity.ToTable("ARTICULOS_PROVEEDOR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codarticulo).HasColumnName("CODARTICULO");

                entity.Property(e => e.Codprov).HasColumnName("CODPROV");

                entity.Property(e => e.Codsucursal).HasColumnName("CODSUCURSAL");

                entity.Property(e => e.Idcalendario).HasColumnName("IDCALENDARIO");
            });

            modelBuilder.Entity<AsignacionProv>(entity =>
            {
                entity.ToTable("ASIGNACION_PROV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idprov).HasColumnName("IDPROV");

                entity.Property(e => e.Idsuc).HasColumnName("IDSUC");

                entity.Property(e => e.Idu).HasColumnName("IDU");
            });

            modelBuilder.Entity<Calendario>(entity =>
            {
                entity.ToTable("CALENDARIOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codproveedor).HasColumnName("CODPROVEEDOR");

                entity.Property(e => e.Codsucursal).HasColumnName("CODSUCURSAL");

                entity.Property(e => e.Especial).HasColumnName("ESPECIAL");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");

                entity.Property(e => e.Temporal).HasColumnName("TEMPORAL");
            });

            modelBuilder.Entity<CalendariosChecada>(entity =>
            {
                entity.ToTable("CALENDARIOS_CHECADAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_EMPLEADO");

                entity.Property(e => e.IdPuesto).HasColumnName("ID_PUESTO");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");
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

            modelBuilder.Entity<CatStatusChecada>(entity =>
            {
                entity.ToTable("CAT_STATUS_CHECADAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Descuento>(entity =>
            {
                entity.ToTable("DESCUENTOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codprov).HasColumnName("CODPROV");
            });

            modelBuilder.Entity<DiasEspeciale>(entity =>
            {
                entity.ToTable("DIAS_ESPECIALES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Dia).HasColumnName("DIA");

                entity.Property(e => e.FactorConsumo).HasColumnName("FACTOR_CONSUMO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Semana).HasColumnName("SEMANA");
            });

            modelBuilder.Entity<DiasEspecialesSucursal>(entity =>
            {
                entity.ToTable("DIAS_ESPECIALES_SUCURSAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Articulos).HasColumnName("ARTICULOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Dia).HasColumnName("DIA");

                entity.Property(e => e.FactorConsumo).HasColumnName("FACTOR_CONSUMO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Semana).HasColumnName("SEMANA");

                entity.Property(e => e.Sucursal).HasColumnName("SUCURSAL");
            });

            modelBuilder.Entity<InventarioTeorico>(entity =>
            {
                entity.ToTable("INVENTARIO_TEORICO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idfront).HasColumnName("IDFRONT");
            });

            modelBuilder.Entity<LogDiferencia>(entity =>
            {
                entity.ToTable("LOG_DIFERENCIAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codalm)
                    .HasMaxLength(50)
                    .HasColumnName("CODALM");

                entity.Property(e => e.Codart).HasColumnName("CODART");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Idu).HasColumnName("IDU");

                entity.Property(e => e.Justificacion).HasColumnName("JUSTIFICACION");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.Property(e => e.ValAntes).HasColumnName("VAL_ANTES");

                entity.Property(e => e.ValDespues).HasColumnName("VAL_DESPUES");
            });

            modelBuilder.Entity<Modificacione>(entity =>
            {
                entity.ToTable("MODIFICACIONES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codarticulo).HasColumnName("CODARTICULO");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .HasColumnName("COMENTARIO");

                entity.Property(e => e.Enviado).HasColumnName("ENVIADO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");

                entity.Property(e => e.Justificacion).HasColumnName("JUSTIFICACION");

                entity.Property(e => e.Modificacion)
                    .HasMaxLength(255)
                    .HasColumnName("MODIFICACION");

                entity.Property(e => e.Numpedido).HasColumnName("NUMPEDIDO");

                entity.Property(e => e.PedidoSerie)
                    .HasMaxLength(50)
                    .HasColumnName("PEDIDO_SERIE");

                entity.Property(e => e.ValAntes)
                    .HasMaxLength(255)
                    .HasColumnName("VAL_ANTES");

                entity.Property(e => e.ValDespues)
                    .HasMaxLength(255)
                    .HasColumnName("VAL_DESPUES");
            });

            modelBuilder.Entity<Notificacione>(entity =>
            {
                entity.ToTable("NOTIFICACIONES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Success).HasColumnName("SUCCESS");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("PARAMETROS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");
            });

            modelBuilder.Entity<PedSucArticulo>(entity =>
            {
                entity.ToTable("PED_SUC_ARTICULOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codart).HasColumnName("CODART");

                entity.Property(e => e.Codproveedor).HasColumnName("CODPROVEEDOR");
            });

            modelBuilder.Entity<PedSucProveedore>(entity =>
            {
                entity.ToTable("PED_SUC_PROVEEDORES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codproveedor).HasColumnName("CODPROVEEDOR");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("PEDIDOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datam).HasColumnName("DATAM");

                entity.Property(e => e.Estatus).HasColumnName("ESTATUS");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Idcal).HasColumnName("IDCAL");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");

                entity.Property(e => e.Numpedido)
                    .HasMaxLength(50)
                    .HasColumnName("NUMPEDIDO");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(50)
                    .HasColumnName("SUCURSAL");

                entity.Property(e => e.Temporal).HasColumnName("TEMPORAL");
            });

            modelBuilder.Entity<PedidosSucursale>(entity =>
            {
                entity.ToTable("PEDIDOS_SUCURSALES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datam).HasColumnName("DATAM");

                entity.Property(e => e.Estatus).HasColumnName("ESTATUS");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");

                entity.Property(e => e.Numpedido).HasColumnName("NUMPEDIDO");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Sucursal).HasColumnName("SUCURSAL");
            });

            modelBuilder.Entity<Retornable>(entity =>
            {
                entity.ToTable("RETORNABLES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codart).HasColumnName("CODART");

                entity.Property(e => e.Codprov).HasColumnName("CODPROV");
            });

            modelBuilder.Entity<Sesione>(entity =>
            {
                entity.ToTable("SESIONES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Activo).HasColumnName("ACTIVO");

                entity.Property(e => e.Idu).HasColumnName("IDU");
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

            modelBuilder.Entity<UsuariosSucursal>(entity =>
            {
                entity.ToTable("USUARIOS_SUCURSAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idsuc).HasColumnName("IDSUC");

                entity.Property(e => e.Idu).HasColumnName("IDU");
            });

            modelBuilder.Entity<ValidacionPedido>(entity =>
            {
                entity.ToTable("VALIDACION_PEDIDOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idu).HasColumnName("IDU");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
