using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Formatosarticulo
    {
        public int Codarticulo { get; set; }
        public int Codformato { get; set; }
        public string? Codbarras { get; set; }
        public string? Compra { get; set; }
        public string? Venta { get; set; }
        public string? Visibleenventa { get; set; }
        public string? Visibleencompra { get; set; }
    }
}
