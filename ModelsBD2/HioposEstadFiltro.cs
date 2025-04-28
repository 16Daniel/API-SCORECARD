using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class HioposEstadFiltro
    {
        public int Id { get; set; }
        public string Idfiltro { get; set; } = null!;
        public string Valor { get; set; } = null!;

        public virtual HioposEstad IdNavigation { get; set; } = null!;
    }
}
