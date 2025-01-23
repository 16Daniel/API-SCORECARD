using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Albventagp
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
