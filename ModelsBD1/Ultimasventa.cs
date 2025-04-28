using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Ultimasventa
    {
        public int Codcliente { get; set; }
        public string N { get; set; } = null!;
        public int Idx { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Diasultventa { get; set; }
        public int? Codmoneda { get; set; }
        public string? Referencia { get; set; }
        public int? Codarticulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Unid1v { get; set; }
        public double? Unid2v { get; set; }
        public double? Unid3v { get; set; }
        public double? Unid4v { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public double? Total { get; set; }
    }
}
