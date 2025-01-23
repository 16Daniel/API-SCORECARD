using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Vacacionesmotivo
    {
        public int Codmotivo { get; set; }
        public string Motivo { get; set; } = null!;
        public bool Pagado { get; set; }
        public byte[]? Version { get; set; }
    }
}
