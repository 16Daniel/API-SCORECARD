using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemAccione
    {
        public int Idfront { get; set; }
        public int Accion { get; set; }
        public int Identidad { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
