using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Situacionesarticulo
    {
        public int Codarticulo { get; set; }
        public int Codsituacion { get; set; }
        public byte[]? Version { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual Situacione CodsituacionNavigation { get; set; } = null!;
    }
}
