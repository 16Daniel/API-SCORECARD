using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Promocionesidioma
    {
        public int Idpromocion { get; set; }
        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }
        public string? Textoimprimir { get; set; }

        public virtual Promocione IdpromocionNavigation { get; set; } = null!;
    }
}
