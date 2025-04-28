using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ItProducto
    {
        public string Rfc { get; set; } = null!;
        public string NoIdentificacion { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string? Umedida { get; set; }
        public decimal? Uds { get; set; }
    }
}
