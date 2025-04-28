using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Stocksporz
    {
        public int Fo { get; set; }
        public int Caja { get; set; }
        public int Z { get; set; }
        public int Codarticulo { get; set; }
        public string Codalmacen { get; set; } = null!;
        public double? Stock { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
