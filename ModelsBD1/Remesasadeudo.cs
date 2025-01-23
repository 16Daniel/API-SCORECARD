using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Remesasadeudo
    {
        public int Numeroremesa { get; set; }
        public int Codcliente { get; set; }
        public string? Ordenadeudo { get; set; }
        public int? Subnorma { get; set; }
        public int? Secuenciaadeudo { get; set; }

        public virtual Remesa NumeroremesaNavigation { get; set; } = null!;
    }
}
