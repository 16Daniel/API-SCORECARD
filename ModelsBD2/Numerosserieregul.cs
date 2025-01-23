using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Numerosserieregul
    {
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Codalmacen { get; set; } = null!;
        public double? Unidades { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
