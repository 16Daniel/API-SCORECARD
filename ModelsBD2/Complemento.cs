using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Complemento
    {
        public string Rfc { get; set; } = null!;
        public string Noidentificacion { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Refproveedor { get; set; }
        public string Umedida { get; set; } = null!;
        public decimal Uds { get; set; }
    }
}
