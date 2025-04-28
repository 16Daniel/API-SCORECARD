using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Etiquetasenviolin
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numpartida { get; set; }
        public int Numembalaje { get; set; }
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Unidades { get; set; }

        public virtual Etiquetasenviocab Etiquetasenviocab { get; set; } = null!;
    }
}
