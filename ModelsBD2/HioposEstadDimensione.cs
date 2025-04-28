using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class HioposEstadDimensione
    {
        public int Id { get; set; }
        public int Dimension { get; set; }
        public string? Campolibre { get; set; }

        public virtual HioposEstad IdNavigation { get; set; } = null!;
    }
}
