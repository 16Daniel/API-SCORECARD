using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Incidenciasnoautovalidable
    {
        public int Idincidencia { get; set; }
        public string? Problemas { get; set; }

        public virtual Incidencia IdincidenciaNavigation { get; set; } = null!;
    }
}
