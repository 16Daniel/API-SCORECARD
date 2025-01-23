using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Accionespromocionlin
    {
        public int Idpromocion { get; set; }
        public int Idaccion { get; set; }
        public int Posicion { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public virtual Accionespromocion Id { get; set; } = null!;
    }
}
