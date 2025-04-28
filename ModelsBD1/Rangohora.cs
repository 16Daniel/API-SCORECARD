using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Rangohora
    {
        public int Idperiodo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Horain { get; set; }
        public DateTime? Horafin { get; set; }
    }
}
