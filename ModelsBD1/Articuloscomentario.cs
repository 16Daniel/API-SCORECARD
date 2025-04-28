using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articuloscomentario
    {
        public int Codarticulo { get; set; }
        public int Numcomentario { get; set; }
        public string? Comentario { get; set; }
        public string? Imprimible { get; set; }
        public int? Codidioma { get; set; }
        public string? Visibleweb { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
