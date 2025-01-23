using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Albventatarjetaembarque
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string? Tarjetaembarque { get; set; }
        public string? Aeropuertoorigen { get; set; }
        public string? Aeropuertodestino { get; set; }
        public string? Numerovuelo { get; set; }
        public string? Clase { get; set; }
        public string? Codnacionalidad { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
