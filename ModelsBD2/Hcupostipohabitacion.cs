using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hcupostipohabitacion
    {
        public int Idcupo { get; set; }
        public int Tipohabitacion { get; set; }

        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
    }
}
