using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemSecsimpresora
    {
        public int Idfront { get; set; }
        public string Nombreformato { get; set; } = null!;
        public int Codsecuencia { get; set; }
        public string? Secuencia { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
