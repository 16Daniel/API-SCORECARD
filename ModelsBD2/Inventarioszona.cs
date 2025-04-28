using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Inventarioszona
    {
        public DateTime Fecha { get; set; }
        public string Codalmacen { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public double? Recuento { get; set; }

        public virtual Inventario Inventario { get; set; } = null!;
    }
}
