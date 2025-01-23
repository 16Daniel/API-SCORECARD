using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articulosdoc
    {
        public int Codarticulo { get; set; }
        public int Tipo { get; set; }
        public string? Path { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
