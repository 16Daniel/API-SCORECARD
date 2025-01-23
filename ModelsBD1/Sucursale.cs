using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Sucursale
    {
        public Sucursale()
        {
            Sucursalespermisos = new HashSet<Sucursalespermiso>();
        }

        public int Idsucursal { get; set; }
        public string? Descripcion { get; set; }
        public string? Usuario { get; set; }
        public string? Pass { get; set; }

        public virtual ICollection<Sucursalespermiso> Sucursalespermisos { get; set; }
    }
}
