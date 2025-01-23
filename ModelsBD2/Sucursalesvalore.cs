using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Sucursalesvalore
    {
        public int Idsucursal { get; set; }
        public int Idpermiso { get; set; }
        public int Orden { get; set; }
        public string? Valor { get; set; }

        public virtual Sucursalespermiso Id { get; set; } = null!;
    }
}
