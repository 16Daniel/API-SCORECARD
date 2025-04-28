using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class TPedidosEntrega
    {
        public TPedidosEntrega()
        {
            TFotosPedidosEntregas = new HashSet<TFotosPedidosEntrega>();
        }

        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public DateTime? FechaProg { get; set; }
        public DateTime? FechaReal { get; set; }
        public string? Comentarios { get; set; }
        public int Estatus { get; set; }
        public int IdSucursal { get; set; }

        public virtual TEstatusPedidosEntrega EstatusNavigation { get; set; } = null!;
        public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
        public virtual RemFront IdSucursalNavigation { get; set; } = null!;
        public virtual ICollection<TFotosPedidosEntrega> TFotosPedidosEntregas { get; set; }
    }
}
