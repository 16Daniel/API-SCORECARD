using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Preciossuplemento
    {
        public int Codarticulo { get; set; }
        public int Codsuplemento { get; set; }
        public int Idtarifav { get; set; }
        public DateTime Fechaini { get; set; }
        public DateTime Fechafin { get; set; }
        public double? Valor { get; set; }
        public string Diasemana { get; set; } = null!;

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
