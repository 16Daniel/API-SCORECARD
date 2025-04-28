using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Modificadoresarticulo
    {
        public int Codarticulo { get; set; }
        public int Codmodificador { get; set; }
        public string? Multiselec { get; set; }
        public int? Posicion { get; set; }
        public int? Orden { get; set; }
        public int? Limite { get; set; }
        public short? Minimo { get; set; }
        public bool? Auto { get; set; }
        public int? Gratis { get; set; }
        public int? Idtarifav { get; set; }
        public bool? Ordenopcional { get; set; }
    }
}
