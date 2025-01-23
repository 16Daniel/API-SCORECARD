using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class CmrcParametro
    {
        public int Id { get; set; }
        public int? Tipo { get; set; }
        public int? Grupo { get; set; }
        public int? ValorInt { get; set; }
        public string? ValorString { get; set; }
        public DateTime? ValorFecha { get; set; }
        public decimal? ValorDecimal { get; set; }
        public double? ValorFloat { get; set; }
        public bool? ValorBool { get; set; }
    }
}
