using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Repartostock
    {
        public int Id { get; set; }
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Almorig { get; set; } = null!;
        public string Almdest { get; set; } = null!;
        public double? Stockfut { get; set; }
        public double? Udstotal { get; set; }
        public double? Uds { get; set; }
        public int? Idgrupoalm { get; set; }
        public double? Stockini { get; set; }
        public double? Stockpedidos { get; set; }
        public double? Udspropuestas { get; set; }
        public int? Codigo { get; set; }
        public string? Sudocumento { get; set; }

        public virtual Repartostockcab? CodigoNavigation { get; set; }
    }
}
