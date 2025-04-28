using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IeHecho
    {
        public IeHecho()
        {
            IeMetricas = new HashSet<IeMetrica>();
            IdCubos = new HashSet<IeCubo>();
        }

        public int IdHecho { get; set; }
        public string NameHecho { get; set; } = null!;
        public string TablasOrigen { get; set; } = null!;
        public string SqlTablasOrigen { get; set; } = null!;
        public bool? Visible { get; set; }
        public string? IdTitulo { get; set; }
        public string CondicionesWhere { get; set; } = null!;

        public virtual ICollection<IeMetrica> IeMetricas { get; set; }

        public virtual ICollection<IeCubo> IdCubos { get; set; }
    }
}
