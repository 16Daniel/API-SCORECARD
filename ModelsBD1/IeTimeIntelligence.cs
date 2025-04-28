using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeTimeIntelligence
    {
        public int IdInforme { get; set; }
        public int IdControlInforme { get; set; }
        public int IdMetrica { get; set; }
        public int IdDimension { get; set; }
        public int IdJerarquia { get; set; }
        public int IdAtributo { get; set; }
        public int IdHecho { get; set; }
        public bool HastaFecha { get; set; }

        public virtual IeAtributo Id { get; set; } = null!;
        public virtual IeControlesInforme Id1 { get; set; } = null!;
        public virtual IeMetrica IdNavigation { get; set; } = null!;
    }
}
