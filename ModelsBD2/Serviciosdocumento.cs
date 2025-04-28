using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Serviciosdocumento
    {
        public double Idintervencion { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int Contador { get; set; }
        public string? Ruta { get; set; }
        public int? Ordenfoto { get; set; }

        public virtual Servicio Servicio { get; set; } = null!;
    }
}
