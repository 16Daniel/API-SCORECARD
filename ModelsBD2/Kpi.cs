using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Kpi
    {
        public Kpi()
        {
            KpiDetallekpis = new HashSet<KpiDetallekpi>();
            KpiFiltroDefs = new HashSet<KpiFiltroDef>();
            KpiUsuarios = new HashSet<KpiUsuario>();
        }

        public int Idkpi { get; set; }
        public string? Nombre { get; set; }
        public int? Tipo { get; set; }
        public string? Sql { get; set; }
        public string? Wheresql { get; set; }
        public int? Tiporesultado { get; set; }
        public int? Esmedia { get; set; }
        public int? Detalledef { get; set; }

        public virtual ICollection<KpiDetallekpi> KpiDetallekpis { get; set; }
        public virtual ICollection<KpiFiltroDef> KpiFiltroDefs { get; set; }
        public virtual ICollection<KpiUsuario> KpiUsuarios { get; set; }
    }
}
