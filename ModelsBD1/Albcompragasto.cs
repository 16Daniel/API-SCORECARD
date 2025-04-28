using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albcompragasto
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int Idgasto { get; set; }
        public double? Importe { get; set; }
        public int? Codmoneda { get; set; }
        public int? Ordengasto { get; set; }
        public int Codarticulo { get; set; }
        public bool? Enfactura { get; set; }
        public int? Numlindoc { get; set; }
        public string? Numseriegasto { get; set; }
        public int? Numalbarangasto { get; set; }
        public string? Ngasto { get; set; }
        public string? Sobrelineaspositivas { get; set; }

        public virtual Albcompralin NNavigation { get; set; } = null!;
    }
}
