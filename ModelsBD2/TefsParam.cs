using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class TefsParam
    {
        public int Idtef { get; set; }
        public int Idparam { get; set; }
        public int Tipo { get; set; }
        public string? Nombre { get; set; }
        public int Aplicacion { get; set; }

        public virtual Tef IdtefNavigation { get; set; } = null!;
    }
}
