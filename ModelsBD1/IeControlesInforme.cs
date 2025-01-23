using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeControlesInforme
    {
        public IeControlesInforme()
        {
            IeFiltrosCuboSbs = new HashSet<IeFiltrosCuboSb>();
            IeTimeIntelligences = new HashSet<IeTimeIntelligence>();
            Ids = new HashSet<IeAtributo>();
            IdsNavigation = new HashSet<IeMetrica>();
        }

        public int IdInforme { get; set; }
        public int IdControlInforme { get; set; }
        public byte[]? Configuracion { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool EsTabla { get; set; }
        public string? BitsConfiguracion { get; set; }
        public bool Top10 { get; set; }
        public bool MostrarOtros { get; set; }
        public bool Peores { get; set; }
        public int NumValues { get; set; }
        public int? SizeX { get; set; }
        public int? SizeY { get; set; }
        public int IdCubo { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaAct { get; set; }
        public int? TipoPeriodo { get; set; }
        public int? IndicePrimerValor { get; set; }
        public DateTime? FechaIniComparar { get; set; }
        public DateTime? FechaFinComparar { get; set; }
        public int? TipoComparar { get; set; }

        public virtual IeCubo IdCuboNavigation { get; set; } = null!;
        public virtual IeInforme IdInformeNavigation { get; set; } = null!;
        public virtual ICollection<IeFiltrosCuboSb> IeFiltrosCuboSbs { get; set; }
        public virtual ICollection<IeTimeIntelligence> IeTimeIntelligences { get; set; }

        public virtual ICollection<IeAtributo> Ids { get; set; }
        public virtual ICollection<IeMetrica> IdsNavigation { get; set; }
    }
}
