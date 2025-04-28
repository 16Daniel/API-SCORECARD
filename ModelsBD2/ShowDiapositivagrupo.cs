using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ShowDiapositivagrupo
    {
        public int Idgrupo { get; set; }
        public int Idfront { get; set; }
        public int? Iddiapositiva { get; set; }
        public byte[]? Version { get; set; }

        public virtual ShowDiapositiva? IddiapositivaNavigation { get; set; }
        public virtual Gruposarticulo IdgrupoNavigation { get; set; } = null!;
    }
}
