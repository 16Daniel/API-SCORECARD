using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventaregalo
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Idregalo { get; set; }
        public int Numlinea { get; set; }
        public double Unidades { get; set; }
        public double? Unidadesabonadas { get; set; }
        public int? Codvendedor { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
