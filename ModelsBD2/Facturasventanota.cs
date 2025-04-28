using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Facturasventanota
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public string Numserienotas { get; set; } = null!;
        public int Numfacturanotas { get; set; }
        public string Nnotas { get; set; } = null!;

        public virtual Facturasventum NNavigation { get; set; } = null!;
    }
}
