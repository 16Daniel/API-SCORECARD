using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pedventaconsumo
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Codarticulo { get; set; }
        public double? Consumo { get; set; }
        public string? Codalmacen { get; set; }

        public virtual Pedventacab NNavigation { get; set; } = null!;
    }
}
