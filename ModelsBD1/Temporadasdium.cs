using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Temporadasdium
    {
        public DateTime Fecha { get; set; }
        public int Idtemporada { get; set; }

        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
