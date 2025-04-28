using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class NetPeticionReenvio
    {
        public Guid IdTerminal { get; set; }
        public int IdEntidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual NetTerminal IdTerminalNavigation { get; set; } = null!;
    }
}
