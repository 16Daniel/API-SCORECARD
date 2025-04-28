using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemTerminale
    {
        public RemTerminale()
        {
            RemTerminaleslins = new HashSet<RemTerminaleslin>();
        }

        public int Idfront { get; set; }
        public int Idterminal { get; set; }
        public string? Nombre { get; set; }
        public string? Versionexe { get; set; }
        public string? Actualizado { get; set; }
        public string? Versionmng { get; set; }
        public string? Versionbas { get; set; }
        public string? Versionorg { get; set; }
        public string? Exeactualizado { get; set; }
        public string? Progsqueejecuta { get; set; }
        public bool Conectado { get; set; }
        public string? Versionpym { get; set; }
        public string? Versioncrm { get; set; }
        public string? Versionhba { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
        public virtual ICollection<RemTerminaleslin> RemTerminaleslins { get; set; }
    }
}
