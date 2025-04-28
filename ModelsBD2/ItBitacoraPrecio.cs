using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItBitacoraPrecio
    {
        public int Id { get; set; }
        public string? Numserie { get; set; }
        public int? Numalbaran { get; set; }
        public int? Codproveedor { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idtarifav { get; set; }
        public decimal? Pneto { get; set; }
        public decimal? Pbruto { get; set; }
        public int? Codarticulo { get; set; }
    }
}
