using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarifashotelcalendariodefecto
    {
        public DateTime Dia { get; set; }
        public int Idtemporada { get; set; }
        public byte[]? Version { get; set; }

        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
