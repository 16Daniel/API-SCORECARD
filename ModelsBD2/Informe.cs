using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Informe
    {
        public Informe()
        {
            EstadisticaConfigs = new HashSet<EstadisticaConfig>();
            Estadisticas = new HashSet<Estadistica>();
            Informecolumnas = new HashSet<Informecolumna>();
            Informefiltros = new HashSet<Informefiltro>();
            Informeparametros = new HashSet<Informeparametro>();
            Miscubosolaps = new HashSet<Miscubosolap>();
        }

        public int Idinforme { get; set; }
        public int Idtipo { get; set; }
        public string? Nombre { get; set; }
        public byte[]? Informe1 { get; set; }
        public string? Version { get; set; }
        public byte[]? Versiones { get; set; }
        public bool? Remoto { get; set; }
        public bool? Descargado { get; set; }

        public virtual ICollection<EstadisticaConfig> EstadisticaConfigs { get; set; }
        public virtual ICollection<Estadistica> Estadisticas { get; set; }
        public virtual ICollection<Informecolumna> Informecolumnas { get; set; }
        public virtual ICollection<Informefiltro> Informefiltros { get; set; }
        public virtual ICollection<Informeparametro> Informeparametros { get; set; }
        public virtual ICollection<Miscubosolap> Miscubosolaps { get; set; }
    }
}
