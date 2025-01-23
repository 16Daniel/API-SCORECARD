using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeCamposRelacionale
    {
        public IeCamposRelacionale()
        {
            IeCamposOrigenesRelacionales = new HashSet<IeCamposOrigenesRelacionale>();
            IeFiltrosOrigens = new HashSet<IeFiltrosOrigen>();
        }

        public int IdCampoRelacional { get; set; }
        public string TablaRelacional { get; set; } = null!;
        public string CampoRelacional { get; set; } = null!;
        public int TipoRelacional { get; set; }
        public int Tamanyo { get; set; }

        public virtual ICollection<IeCamposOrigenesRelacionale> IeCamposOrigenesRelacionales { get; set; }
        public virtual ICollection<IeFiltrosOrigen> IeFiltrosOrigens { get; set; }
    }
}
