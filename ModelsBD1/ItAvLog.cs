using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ItAvLog
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public DateTime Fecha { get; set; }
        public int Reg { get; set; }
    }
}
