using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Modificadoreslin
    {
        public int Codmodificador { get; set; }
        public int Codarticulocom { get; set; }
        public int Esarticulo { get; set; }
        public double? Dosis { get; set; }
        public double? Incprecio { get; set; }
        public int Posicion { get; set; }
        public bool? Predeterminado { get; set; }
        public int Codformato { get; set; }
        public bool? Esdto { get; set; }
    }
}
