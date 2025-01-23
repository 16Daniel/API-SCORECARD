using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ItVentaB
    {
        public string Bd { get; set; } = null!;
        public string? Sucursal { get; set; }
        public int? Venta7Dias { get; set; }
    }
}
