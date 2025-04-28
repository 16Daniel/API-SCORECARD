using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vacacionesempleado
    {
        public int Codempleado { get; set; }
        public int Codvaclin { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string? Motivo { get; set; }
        public int? Codmotivo { get; set; }
        public DateTime? Fechasolicitud { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fechavalidacion { get; set; }
        public int? Validadopor { get; set; }
        public int? Dias { get; set; }
        public double? Horas { get; set; }
    }
}
