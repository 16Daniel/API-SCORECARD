using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class LastsalesArticuloslin
    {
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Codbarras { get; set; }
        public string? Codbarras2 { get; set; }
        public string? Codbarras3 { get; set; }
        public string? Descatalogado { get; set; }

        public virtual LastsalesArticulo CodarticuloNavigation { get; set; } = null!;
    }
}
