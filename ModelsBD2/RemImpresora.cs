using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemImpresora
    {
        public int Idfront { get; set; }
        public string Nombreimpresora { get; set; } = null!;
        public string? Nombreformato { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
