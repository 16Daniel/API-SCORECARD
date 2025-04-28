using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Registroanulacione
    {
        public int Numlinea { get; set; }
        public double? Codvendedor { get; set; }
        public int? Codcliente { get; set; }
        public int? Codarticulo { get; set; }
        public string? Descripcion { get; set; }
        public double? Unidades { get; set; }
        public double? Preciodefecto { get; set; }
        public string? Concepto { get; set; }
        public string? Estocado { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public string? Serietrasp { get; set; }
        public int? Numtrasp { get; set; }
        public double? Coste { get; set; }
        public double? Costeiva { get; set; }
        public int? Caja { get; set; }
        public int? Z { get; set; }
    }
}
