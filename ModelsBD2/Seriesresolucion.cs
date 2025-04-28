using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Seriesresolucion
    {
        public string Serieresol { get; set; } = null!;
        public string Numresol { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public int? Numeroinicial { get; set; }
        public int? Numerofinal { get; set; }
        public int? Activo { get; set; }
        public int? Contador { get; set; }
        public DateTime? Fechaingreso { get; set; }
        public DateTime? Fechavencimiento { get; set; }
    }
}
