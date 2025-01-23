using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Regularizacion
    {
        public string Codalmacen { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Unidades { get; set; }
        public double? Stockfinal { get; set; }
        public string? Cuadrado { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
