using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Facturasventaret
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public double? Base { get; set; }
        public double? Porcret { get; set; }
        public double? Importe { get; set; }
        public int? Tiporet { get; set; }
        public int? Regimret { get; set; }

        public virtual Facturasventum NNavigation { get; set; } = null!;
    }
}
