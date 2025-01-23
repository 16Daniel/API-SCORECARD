using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemInfoversionesfront
    {
        public int Idfront { get; set; }
        public int Entitat { get; set; }
        public long? Version { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
