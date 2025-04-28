using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventaconsumicione
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int Idlin { get; set; }
        public int? Tipotarjeta { get; set; }
        public int? Idtarjeta { get; set; }
        public double? Importerebajado { get; set; }
        public double? Dtoaplicado { get; set; }
        public int? Tarifaaplicada { get; set; }
        public bool? Esconsumicion { get; set; }

        public virtual Albventalin NNavigation { get; set; } = null!;
    }
}
