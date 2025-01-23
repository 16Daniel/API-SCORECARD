using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Turnosarticulosdefecto
    {
        public int Codturno { get; set; }
        public int Codarticulo { get; set; }
        public double Uds { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual Turno CodturnoNavigation { get; set; } = null!;
    }
}
