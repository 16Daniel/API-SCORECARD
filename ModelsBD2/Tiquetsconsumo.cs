using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiquetsconsumo
    {
        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int Codarticulo { get; set; }
        public double? Consumo { get; set; }

        public virtual Tiquetslin Tiquetslin { get; set; } = null!;
    }
}
