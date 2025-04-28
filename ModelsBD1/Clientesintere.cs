using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Clientesintere
    {
        public int Codcliente { get; set; }
        public int Codinteres { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Codempleado { get; set; }
        public int? Gradointeres { get; set; }
        public string? Observaciones { get; set; }

        public virtual Interese CodinteresNavigation { get; set; } = null!;
    }
}
