using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Fpagoproveedor
    {
        public int Codproveedor { get; set; }
        public string Tipo { get; set; } = null!;
        public string Codformapago { get; set; } = null!;
        public int Coddtopp { get; set; }
        public double? Dtopp { get; set; }
        public double? Cantidad { get; set; }
        public string? Serie { get; set; }

        public virtual Formaspago CodformapagoNavigation { get; set; } = null!;
        public virtual Proveedore CodproveedorNavigation { get; set; } = null!;
    }
}
