using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hcierrehabitacione
    {
        public int Idhotel { get; set; }
        public short Planta { get; set; }
        public int Habitacion { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string? Motivo { get; set; }
        public int? Codempleado { get; set; }
        public int? Idbloqueo { get; set; }
        public DateTime? Hora { get; set; }
    }
}
