using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Mappingssql
    {
        public int Idmap { get; set; }
        public int Cuando { get; set; }
        public int Posicion { get; set; }
        public int? Idsql { get; set; }

        public virtual Mappingscab IdmapNavigation { get; set; } = null!;
    }
}
