using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Paqueteshotelcliente
    {
        public int Codtarifa { get; set; }
        public int Codcliente { get; set; }
        public int Posicion { get; set; }
        public bool? Combruto { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
    }
}
