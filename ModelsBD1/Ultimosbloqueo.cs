using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Ultimosbloqueo
    {
        public int Idfront { get; set; }
        public string Terminal { get; set; } = null!;
        public int? Idbloqueo { get; set; }
    }
}
