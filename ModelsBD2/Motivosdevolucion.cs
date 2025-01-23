using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Motivosdevolucion
    {
        public Motivosdevolucion()
        {
            IdTienda = new HashSet<NetTiendum>();
        }

        public int Idmotivo { get; set; }
        public string? Descripcion { get; set; }
        public string? Codalmacen { get; set; }

        public virtual ICollection<NetTiendum> IdTienda { get; set; }
    }
}
