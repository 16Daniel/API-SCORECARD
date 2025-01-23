using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class CmrcFotosarticulo
    {
        public int Codarticulo { get; set; }
        public int Posicion { get; set; }
        public int? Orden { get; set; }
        public string? Portada { get; set; }
        public int? Codfoto { get; set; }
        public byte[] Version { get; set; } = null!;
        public int Idimageps { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
