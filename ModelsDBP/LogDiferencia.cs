using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class LogDiferencia
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public string ValAntes { get; set; } = null!;
        public string ValDespues { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idu { get; set; }
        public string Justificacion { get; set; } = null!;
        public int? Codart { get; set; }
        public string? Codalm { get; set; }
    }
}
