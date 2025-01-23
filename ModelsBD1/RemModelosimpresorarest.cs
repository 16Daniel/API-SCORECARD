using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemModelosimpresorarest
    {
        public int Idfront { get; set; }
        public string Modeloimpresora { get; set; } = null!;
        public short? Gruposecuencias { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
