using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Terminaleslin
    {
        public int Idterminal { get; set; }
        public int Tipodoc { get; set; }
        public string? Impresora { get; set; }
        public string? Disenyimp { get; set; }
        public string? Disenymail { get; set; }
        public string? Disenyimpn { get; set; }
        public string? Dismailn { get; set; }

        public virtual Terminale IdterminalNavigation { get; set; } = null!;
    }
}
