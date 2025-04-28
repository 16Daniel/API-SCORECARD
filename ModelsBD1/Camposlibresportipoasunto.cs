using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Camposlibresportipoasunto
    {
        public int Idtipoasunto { get; set; }
        public string Camp { get; set; } = null!;
        public int Orden { get; set; }

        public virtual Tipoasunto IdtipoasuntoNavigation { get; set; } = null!;
    }
}
