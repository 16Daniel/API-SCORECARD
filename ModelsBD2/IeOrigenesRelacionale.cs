using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IeOrigenesRelacionale
    {
        public IeOrigenesRelacionale()
        {
            IeAtributos = new HashSet<IeAtributo>();
            IeCamposOrigenesRelacionales = new HashSet<IeCamposOrigenesRelacionale>();
            IeMetricas = new HashSet<IeMetrica>();
        }

        public int IdOrigenRelacional { get; set; }
        public string NameOrigen { get; set; } = null!;
        public int TipoRelacional { get; set; }
        public int Tamanyo { get; set; }
        public string? Formula { get; set; }

        public virtual ICollection<IeAtributo> IeAtributos { get; set; }
        public virtual ICollection<IeCamposOrigenesRelacionale> IeCamposOrigenesRelacionales { get; set; }
        public virtual ICollection<IeMetrica> IeMetricas { get; set; }
    }
}
