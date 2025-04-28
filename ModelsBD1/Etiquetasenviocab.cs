using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Etiquetasenviocab
    {
        public Etiquetasenviocab()
        {
            Etiquetasenviolins = new HashSet<Etiquetasenviolin>();
        }

        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numpartida { get; set; }
        public int Numembalaje { get; set; }
        public int? Numbultos { get; set; }
        public double? Pesoneto { get; set; }
        public double? Pesobruto { get; set; }
        public double? Longitud { get; set; }
        public double? Altura { get; set; }
        public double? Anchura { get; set; }
        public string? Codbarras { get; set; }
        public string? Codembalaje { get; set; }

        public virtual Etiquetasenvio Etiquetasenvio { get; set; } = null!;
        public virtual ICollection<Etiquetasenviolin> Etiquetasenviolins { get; set; }
    }
}
