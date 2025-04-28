using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Precioshabitaciondium
    {
        public DateTime Dia { get; set; }
        public int Codcliente { get; set; }
        public int Codtarifa { get; set; }
        public int Codhabitacion { get; set; }
        public double? Precio { get; set; }
        public byte[]? Version { get; set; }

        public virtual Articulo1 CodhabitacionNavigation { get; set; } = null!;
        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
    }
}
