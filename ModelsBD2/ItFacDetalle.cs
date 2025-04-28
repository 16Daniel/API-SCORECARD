using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItFacDetalle
    {
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public int? Albaran { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Total { get; set; }
        public decimal? Dto { get; set; }
        public decimal? Subtotal2 { get; set; }
        public decimal? Tasa { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Z { get; set; }
        public int? Folio { get; set; }
        public DateTime? Pg { get; set; }
        public string? Tipo { get; set; }
        public int? Posicion { get; set; }
        public int? Codformapago { get; set; }
    }
}
