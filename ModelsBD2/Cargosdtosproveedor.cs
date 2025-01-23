using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Cargosdtosproveedor
    {
        public int Codproveedor { get; set; }
        public int Codigo { get; set; }
        public double? Valor { get; set; }

        public virtual Proveedore CodproveedorNavigation { get; set; } = null!;
    }
}
