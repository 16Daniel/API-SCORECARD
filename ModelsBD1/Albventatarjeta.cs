using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventatarjeta
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Idtarjeta { get; set; }
        public double? Saldo { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
