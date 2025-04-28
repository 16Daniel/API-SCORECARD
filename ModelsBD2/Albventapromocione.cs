using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Albventapromocione
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Idpromocion { get; set; }
        public double? Importe { get; set; }
        public double? Importeiva { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
