using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articuloscommerce
    {
        public int Codarticulo { get; set; }
        public int Codidioma { get; set; }
        public byte[]? Desccorta { get; set; }
        public byte[]? Desclarga { get; set; }
        public string? Desccortahtml { get; set; }
        public string? Desclargahtml { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
