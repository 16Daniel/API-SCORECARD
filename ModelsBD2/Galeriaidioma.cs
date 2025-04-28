using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Galeriaidioma
    {
        public int Idgaleria { get; set; }
        public string Ididioma { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual Galerium IdgaleriaNavigation { get; set; } = null!;
    }
}
