using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Dtosocupaciontemporadum
    {
        public int Codtarifa { get; set; }
        public int Idtemporada { get; set; }
        public int Idrango { get; set; }
        public int Codcliente { get; set; }
        public double? Dto0 { get; set; }
        public double? Dto1 { get; set; }
        public double? Dto2 { get; set; }
        public double? Dto3 { get; set; }
        public double? Dto4 { get; set; }
        public double? Dto5 { get; set; }
        public double? Dto6 { get; set; }
        public double? Dto7 { get; set; }
        public double? Dto8 { get; set; }
        public double? Dto9 { get; set; }

        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
        public virtual Tarifashotelrango IdrangoNavigation { get; set; } = null!;
        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
