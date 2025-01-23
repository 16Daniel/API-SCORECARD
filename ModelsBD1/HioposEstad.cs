using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class HioposEstad
    {
        public HioposEstad()
        {
            HioposEstadDimensiones = new HashSet<HioposEstadDimensione>();
            HioposEstadFiltros = new HashSet<HioposEstadFiltro>();
            HioposEstadFiltrosLibres = new HashSet<HioposEstadFiltrosLibre>();
            HioposEstadMetricas = new HashSet<HioposEstadMetrica>();
            HioposEstadSeries = new HashSet<HioposEstadSeries>();
        }

        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int? Ileft { get; set; }
        public int? Itop { get; set; }
        public int? Iheight { get; set; }
        public int? Iwidth { get; set; }
        public int? Tipografico { get; set; }
        public int? Tipovisualizacion { get; set; }
        public int? Rangovisualizacion { get; set; }
        public int? Tipoestad { get; set; }
        public int? Subtipoestad { get; set; }
        public bool? Vervalores { get; set; }
        public int? Anguloetiquetas { get; set; }
        public string? Campoorden { get; set; }
        public string? Tipoorden { get; set; }

        public virtual ICollection<HioposEstadDimensione> HioposEstadDimensiones { get; set; }
        public virtual ICollection<HioposEstadFiltro> HioposEstadFiltros { get; set; }
        public virtual ICollection<HioposEstadFiltrosLibre> HioposEstadFiltrosLibres { get; set; }
        public virtual ICollection<HioposEstadMetrica> HioposEstadMetricas { get; set; }
        public virtual ICollection<HioposEstadSeries> HioposEstadSeries { get; set; }
    }
}
