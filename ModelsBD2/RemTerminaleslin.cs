using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemTerminaleslin
    {
        public int Idfront { get; set; }
        public int Idterminal { get; set; }
        public int Tipodoc { get; set; }
        public string? Impresora { get; set; }
        public string? Disenyimp { get; set; }
        public string? Disenymail { get; set; }
        public string? Disenyimpn { get; set; }
        public string? Dismailn { get; set; }

        public virtual RemTerminale Id { get; set; } = null!;
    }
}
