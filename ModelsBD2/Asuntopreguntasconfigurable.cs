using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Asuntopreguntasconfigurable
    {
        public int Idtipoasunto { get; set; }
        public int Codpregunta { get; set; }
        public int? Orden { get; set; }

        public virtual Tipoasunto IdtipoasuntoNavigation { get; set; } = null!;
    }
}
