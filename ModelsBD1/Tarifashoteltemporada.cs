using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarifashoteltemporada
    {
        public int Codtarifa { get; set; }
        public int Idtemporada { get; set; }
        public int Codcliente { get; set; }
        public int? Cupos { get; set; }
        public int? Release { get; set; }
        public double? Dto { get; set; }
        public byte[]? Version { get; set; }
        public int Idrango { get; set; }
        public double? Comision { get; set; }
        public double? Proddesayuno { get; set; }
        public double? Prodalmuerzo { get; set; }
        public double? Prodcena { get; set; }

        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
