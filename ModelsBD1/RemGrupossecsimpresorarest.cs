using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemGrupossecsimpresorarest
    {
        public int Idfront { get; set; }
        public int Idgruposecuencias { get; set; }
        public string? Nombregruposecuencias { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
