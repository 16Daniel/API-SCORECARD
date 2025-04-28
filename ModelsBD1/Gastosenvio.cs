using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gastosenvio
    {
        public int Idgastoenvio { get; set; }
        public string? Zona { get; set; }
        public double? Importe { get; set; }
        public int? Codarticulo { get; set; }
        public int? Codtransporte { get; set; }
    }
}
