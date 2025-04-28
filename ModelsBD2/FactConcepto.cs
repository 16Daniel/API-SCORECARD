using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class FactConcepto
    {
        public decimal IdConcepto { get; set; }
        public string IdFactura { get; set; } = null!;
        public string? Codigo { get; set; }
        public string? Unidades { get; set; }
        public string? DescripcionConcepto { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? ImporteNeto { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? DescuentoPorc { get; set; }
    }
}
