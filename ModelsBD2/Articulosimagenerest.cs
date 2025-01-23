using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Articulosimagenerest
    {
        public int Codarticulo { get; set; }
        public byte[]? Imagen { get; set; }
        public byte[]? Version { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
