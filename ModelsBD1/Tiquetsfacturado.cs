using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tiquetsfacturado
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public string Numserietiquet { get; set; } = null!;
        public int Numtiquet { get; set; }
        public string Ntiquet { get; set; } = null!;
        public bool? Esdocabono { get; set; }

        public virtual Facturasventum NNavigation { get; set; } = null!;
    }
}
