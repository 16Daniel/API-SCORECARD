using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemInfoentidadesfront
    {
        public int Idfront { get; set; }
        public int Entitat { get; set; }
        public int? Numreg { get; set; }
        public string? Iddescarga { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
