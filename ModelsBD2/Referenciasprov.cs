using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Referenciasprov
    {
        public int Codarticulo { get; set; }
        public string Refproveedor { get; set; } = null!;
        public int Codproveedor { get; set; }
        public double? Udsdefecto { get; set; }
        public string? Principal { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
