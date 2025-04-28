using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mermaslin
    {
        public int Idint { get; set; }
        public int Numlin { get; set; }
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Unidades { get; set; }
        public double? ValoracionPvp { get; set; }
        public double? ValoracionCoste { get; set; }
        public double? Nuevostock { get; set; }

        public virtual Mermascab IdintNavigation { get; set; } = null!;
    }
}
