using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Entregastarjetum
    {
        public int Codcliente { get; set; }
        public string Caja { get; set; } = null!;
        public int Idtarjeta { get; set; }
        public int Idlinea { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Tipo { get; set; }
        public int? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? Puntos { get; set; }
        public double? Consumiciones { get; set; }
        public double? Importe { get; set; }
        public int? Tickets { get; set; }
        public int? Z { get; set; }
    }
}
