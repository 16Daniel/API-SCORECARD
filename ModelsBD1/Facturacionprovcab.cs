using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Facturacionprovcab
    {
        public Facturacionprovcab()
        {
            Facturacionprovlins = new HashSet<Facturacionprovlin>();
        }

        public int Codproveedor { get; set; }
        public int Numconcepto { get; set; }
        public DateTime? Fechacobro { get; set; }
        public string? Siglas { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string? Observaciones { get; set; }
        public string? Numseriefac { get; set; }
        public int? Numfac { get; set; }
        public string? Nfac { get; set; }

        public virtual Proveedore CodproveedorNavigation { get; set; } = null!;
        public virtual ICollection<Facturacionprovlin> Facturacionprovlins { get; set; }
    }
}
