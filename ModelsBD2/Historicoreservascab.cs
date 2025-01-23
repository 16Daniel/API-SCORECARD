using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Historicoreservascab
    {
        public int Id { get; set; }
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public int Empleado { get; set; }
        public int Estado { get; set; }
        public string? Observaciones { get; set; }
        public int? Tipo { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public string? Estadoponer { get; set; }
        public string? Estadoprevio { get; set; }
        public string? Estadoquitar { get; set; }
        public string? Estadofinal { get; set; }
        public string? Gobernanta { get; set; }
        public string? Habitacion { get; set; }
        public string? N { get; set; }
    }
}
