using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class VwProveedore
    {
        public int Codproveedor { get; set; }
        public string Rfc { get; set; } = null!;
        public string? Nomproveedor { get; set; }
        public int Codarticulo { get; set; }
        public decimal? Uds { get; set; }
    }
}
