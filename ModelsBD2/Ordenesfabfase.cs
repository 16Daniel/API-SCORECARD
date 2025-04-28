using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ordenesfabfase
    {
        public string Seriefab { get; set; } = null!;
        public int Numfab { get; set; }
        public int Numfase { get; set; }
        public string Numseriefabricado { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Codempleado { get; set; }
        public string Numseriecomponente { get; set; } = null!;
    }
}
