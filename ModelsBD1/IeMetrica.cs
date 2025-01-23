using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeMetrica
    {
        public IeMetrica()
        {
            IeTimeIntelligences = new HashSet<IeTimeIntelligence>();
            Ids = new HashSet<IeGruposMedida>();
            IdsNavigation = new HashSet<IeControlesInforme>();
        }

        public int IdMetrica { get; set; }
        public int IdHecho { get; set; }
        public int? IdOrigenRelacional { get; set; }
        public string? Mascara { get; set; }
        public int Funcion { get; set; }
        public string? Formula { get; set; }
        public string? Name { get; set; }
        public bool? Visible { get; set; }
        public bool IsCalculo { get; set; }
        public string? IdTitulo { get; set; }

        public virtual IeHecho IdHechoNavigation { get; set; } = null!;
        public virtual IeOrigenesRelacionale? IdOrigenRelacionalNavigation { get; set; }
        public virtual ICollection<IeTimeIntelligence> IeTimeIntelligences { get; set; }

        public virtual ICollection<IeGruposMedida> Ids { get; set; }
        public virtual ICollection<IeControlesInforme> IdsNavigation { get; set; }
    }
}
