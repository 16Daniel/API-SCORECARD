using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Fondocaja
    {
        public string Caja { get; set; } = null!;
        public int Numero { get; set; }
        public string? N { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Z { get; set; }
        public string? Cajafuerte { get; set; }
        public int? Tipomov { get; set; }
        public double? Importe { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Descripcion { get; set; }
        public int? Codempleado { get; set; }
        public bool? Automatico { get; set; }
        public string? Cajadeclarado { get; set; }
        public int? Zdeclarado { get; set; }
        public int? Numerodeclarado { get; set; }
        public int? Codconceptopago { get; set; }
    }
}
