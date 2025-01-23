using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Terminale
    {
        public Terminale()
        {
            Cajasasignada = new HashSet<Cajasasignada>();
            Clientesterminals = new HashSet<Clientesterminal>();
            Configmulticajas = new HashSet<Configmulticaja>();
            Configmulticajaseries = new HashSet<Configmulticajaseries>();
            Proveedoresterminals = new HashSet<Proveedoresterminal>();
            Terminaleslins = new HashSet<Terminaleslin>();
        }

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

        public virtual ICollection<Cajasasignada> Cajasasignada { get; set; }
        public virtual ICollection<Clientesterminal> Clientesterminals { get; set; }
        public virtual ICollection<Configmulticaja> Configmulticajas { get; set; }
        public virtual ICollection<Configmulticajaseries> Configmulticajaseries { get; set; }
        public virtual ICollection<Proveedoresterminal> Proveedoresterminals { get; set; }
        public virtual ICollection<Terminaleslin> Terminaleslins { get; set; }
    }
}
