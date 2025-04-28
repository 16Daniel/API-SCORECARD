using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Historicocomisione
    {
        public int Codvendedor { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public int Codcomision { get; set; }
        public int Tipoarticulo { get; set; }
        public double? Porcentaje { get; set; }
        public double? Total { get; set; }
        public int? Codaux { get; set; }
        public int? Codmoneda { get; set; }
    }
}
