using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Anticipo
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Tipodoc { get; set; }
        public DateTime Fecha { get; set; }
        public int Codcliente { get; set; }
        public string? Mediodepago { get; set; }
        public double? Base { get; set; }
        public int? Tipoiva { get; set; }
        public double? Porciva { get; set; }
        public double? Cuotaiva { get; set; }
        public double? Total { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Concepto { get; set; }
    }
}
