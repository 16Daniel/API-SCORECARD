using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cargosdtoscliente
    {
        public int Codcliente { get; set; }
        public int Codigo { get; set; }
        public double? Valor { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
    }
}
