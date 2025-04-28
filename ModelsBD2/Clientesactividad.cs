using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Clientesactividad
    {
        public int Codcliente { get; set; }
        public int Codactividad { get; set; }
        public int? Codcompetencia { get; set; }
        public double? Compras { get; set; }

        public virtual Actividade CodactividadNavigation { get; set; } = null!;
    }
}
