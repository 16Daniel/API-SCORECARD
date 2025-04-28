using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Procesoslin
    {
        public int Idproceso { get; set; }
        public string Clave { get; set; } = null!;
        public string Subclave { get; set; } = null!;
        public string? Valor { get; set; }

        public virtual Proceso IdprocesoNavigation { get; set; } = null!;
    }
}
