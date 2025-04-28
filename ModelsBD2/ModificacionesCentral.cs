using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ModificacionesCentral
    {
        public int Id { get; set; }
        public int? Identidad { get; set; }
        public bool? Descartado { get; set; }
        public bool? Pedido { get; set; }
        public bool? Bloqueofuerte { get; set; }
        public int? Numero1 { get; set; }
        public int? Numero2 { get; set; }
        public int? Numero3 { get; set; }
        public string? Cadena1 { get; set; }
        public string? Cadena2 { get; set; }
        public string? Cadena3 { get; set; }
        public double? Real1 { get; set; }
        public double? Real2 { get; set; }
        public DateTime? Fecha1 { get; set; }
        public DateTime? Fecha2 { get; set; }
        public DateTime? Fechabloqueo { get; set; }
        public int? Idremtrans { get; set; }
        public bool? Bloqueofront { get; set; }
        public string? Terminal { get; set; }
    }
}
