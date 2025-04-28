using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articulosimagene
    {
        public int Codarticulo { get; set; }
        public int Idimagen { get; set; }
        public int Idhotel { get; set; }
        public byte[]? Imagen { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
