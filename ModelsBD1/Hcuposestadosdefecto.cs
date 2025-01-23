using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hcuposestadosdefecto
    {
        public int Idcupo { get; set; }
        public int Codigo { get; set; }
        public string Idestado { get; set; } = null!;
        public bool? Poner { get; set; }

        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
        public virtual Hestadoshabitacione IdestadoNavigation { get; set; } = null!;
    }
}
