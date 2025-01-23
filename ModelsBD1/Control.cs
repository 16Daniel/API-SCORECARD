using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Control
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
