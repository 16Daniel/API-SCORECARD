using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class TskConfigmarca
    {
        public int Codmarca { get; set; }
        public int Posicion { get; set; }
        public int? CodcanjeMobiliario { get; set; }
        public int? CodcanjeAccesorios { get; set; }
        public int? CodcanjeElectro { get; set; }
        public int? CodexpoMobiliario { get; set; }
        public int? CodexpoAccesorios { get; set; }
        public int? CodexpoElectro { get; set; }
        public int? CodotrasMobiliario { get; set; }
        public int? CodotrasAccesorios { get; set; }
        public int? CodotrasElectro { get; set; }
    }
}
