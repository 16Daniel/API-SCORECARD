using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDashboard
{
    public partial class JobsEjecutado
    {
        public int Id { get; set; }
        public int IdJob { get; set; }
        public DateTime Fecha { get; set; }
    }
}
