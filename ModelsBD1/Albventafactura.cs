using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventafactura
    {
        public string Numserie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public double? Totalneto { get; set; }
        public string? Automatico { get; set; }
        public double? Subtotal { get; set; }
        public double? Ivainc { get; set; }
        public string Serie { get; set; } = null!;
        public int? Codcliente { get; set; }
        public string? Factura { get; set; }
        public int? Fo { get; set; }
    }
}
