using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class VwRnotificacione
    {
        public string? Correo { get; set; }
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int? Codproveedor { get; set; }
        public string? Nomproveedor { get; set; }
        public string? Almacen { get; set; }
        public string? Codalmacen { get; set; }
        public bool Notificacion { get; set; }
        public double? Totneto { get; set; }
        public DateTime? Fechapedido { get; set; }
        public DateTime? Fechaentrega { get; set; }
    }
}
