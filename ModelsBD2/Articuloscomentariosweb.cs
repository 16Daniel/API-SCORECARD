using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Articuloscomentariosweb
    {
        public int Idhotel { get; set; }
        public int Codarticulo { get; set; }
        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }
        public string? Comentario { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
