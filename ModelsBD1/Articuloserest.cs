using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articuloserest
    {
        public int Codarticulo { get; set; }
        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }
        public string? Ingredientes { get; set; }
        public byte[]? Version { get; set; }
        public string? Nombre { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
