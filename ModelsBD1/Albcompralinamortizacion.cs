using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albcompralinamortizacion
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int EnlaceEmpresa { get; set; }
        public int EnlaceEjercicio { get; set; }
        public int Codinmovilizado { get; set; }

        public virtual Albcompracab NNavigation { get; set; } = null!;
    }
}
