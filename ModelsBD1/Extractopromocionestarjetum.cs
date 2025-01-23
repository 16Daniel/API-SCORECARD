using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Extractopromocionestarjetum
    {
        public int Idlinea { get; set; }
        public int? Idtarjeta { get; set; }
        public string? Caja { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Tipo { get; set; }
        public int? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? Puntos { get; set; }
        public double? Consumiciones { get; set; }
        public double? Importe { get; set; }
        public int? Tickets { get; set; }
        public int? Z { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public string? N { get; set; }
        public string? Alias { get; set; }
    }
}
