using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tiposretencion
    {
        public Tiposretencion()
        {
            Tiposretencionlins = new HashSet<Tiposretencionlin>();
            Codproveedors = new HashSet<Proveedore>();
        }

        public int Tipo { get; set; }
        public string? Descripcion { get; set; }
        public string? Cuenta { get; set; }
        public int? Tipofacturacion { get; set; }
        public int? Tiporetencion { get; set; }
        public double? Porcbase { get; set; }
        public double? Sustraendo { get; set; }
        public int? Idclave { get; set; }
        public string? Claveecu { get; set; }

        public virtual Tiposretencionclave? IdclaveNavigation { get; set; }
        public virtual ICollection<Tiposretencionlin> Tiposretencionlins { get; set; }

        public virtual ICollection<Proveedore> Codproveedors { get; set; }
    }
}
