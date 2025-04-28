using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Diasfestivo
    {
        public string Tipo { get; set; } = null!;
        public short AO { get; set; }
        public short Mes { get; set; }
        public short Dia { get; set; }
    }
}
