using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Proveedorescamposlibre
    {
        public int Codproveedor { get; set; }
        public string? Serie { get; set; }
        public string? RecepcionXml { get; set; }

        public virtual Proveedore CodproveedorNavigation { get; set; } = null!;
    }
}
