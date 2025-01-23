using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeUsuariosInforme
    {
        public int IdUsuario { get; set; }
        public int IdInforme { get; set; }

        public virtual IeInforme IdInformeNavigation { get; set; } = null!;
    }
}
