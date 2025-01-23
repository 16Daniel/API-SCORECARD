using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Htareashabitacion
    {
        public DateTime Fecha { get; set; }
        public int Idhotel { get; set; }
        public short Idplanta { get; set; }
        public int Idhabitacion { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Resume { get; set; }
        public DateTime? Stop { get; set; }
        public DateTime? Duracion { get; set; }
        public int? Codempleado { get; set; }
        public string? Opcionesinicio { get; set; }
        public string? Opcionesfin { get; set; }
        public bool? Validado { get; set; }
        public int? Validadopor { get; set; }
        public DateTime? Fechavalidacion { get; set; }
    }
}
