using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Registroincidenciase
    {
        public int Id { get; set; }
        public int Codempleado { get; set; }
        public DateTime Fecha { get; set; }
        public int? Tipoanomalia { get; set; }
        public string? Caja { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? Hora { get; set; }
        public DateTime? Horaentrada { get; set; }
        public DateTime? Horasalida { get; set; }
        public DateTime? Horaentradareal { get; set; }
        public DateTime? Horasalidareal { get; set; }
        public string? Descturno { get; set; }
        public int? Idfront { get; set; }
    }
}
