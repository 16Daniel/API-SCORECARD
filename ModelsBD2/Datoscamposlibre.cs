using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Datoscamposlibre
    {
        public int Codcliente { get; set; }
        public int Codrespuesta { get; set; }
        public int? Orden { get; set; }
        public string? Pregunta { get; set; }
        public string? Texto { get; set; }
        public double? Numero { get; set; }
        public string? Boolea { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Tipo { get; set; }
    }
}
