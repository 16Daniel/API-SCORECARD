using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeAtributo
    {
        public IeAtributo()
        {
            IeTimeIntelligences = new HashSet<IeTimeIntelligence>();
            Ids = new HashSet<IeControlesInforme>();
        }

        public int IdDimension { get; set; }
        public int IdAtributo { get; set; }
        public int? IdOrigenRelacional { get; set; }
        public int TipoAtributo { get; set; }
        public bool? Visible { get; set; }
        public bool? Generar { get; set; }
        public string? ValorDefecto { get; set; }
        public string? IdTitulo { get; set; }
        public string? NameOrigenOrderBy { get; set; }
        public int NumRegistros { get; set; }

        public virtual IeDimensione IdDimensionNavigation { get; set; } = null!;
        public virtual IeOrigenesRelacionale? IdOrigenRelacionalNavigation { get; set; }
        public virtual ICollection<IeTimeIntelligence> IeTimeIntelligences { get; set; }

        public virtual ICollection<IeControlesInforme> Ids { get; set; }
    }
}
