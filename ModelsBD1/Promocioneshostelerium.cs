using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Promocioneshostelerium
    {
        public int Idpromocion { get; set; }
        public int? Idtarjeta { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public DateTime? Horaini { get; set; }
        public DateTime? Horafin { get; set; }
        public int? Codarticulo { get; set; }
        public double? Dto { get; set; }
        public double? Importe { get; set; }
        public bool? Aplicada { get; set; }
        public DateTime? Fechaaplicacion { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public string? N { get; set; }
        public int? Idmotivodto { get; set; }
    }
}
