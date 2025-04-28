using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDashboard
{
    public partial class ReportesBono
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public string Jdata { get; set; } = null!;
        public int? Ids { get; set; }
    }
}
