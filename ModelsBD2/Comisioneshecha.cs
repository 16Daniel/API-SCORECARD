using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Comisioneshecha
    {
        public int Codvendedor { get; set; }
        public DateTime Fechaini { get; set; }
        public DateTime Fechafin { get; set; }
        public double? Ret { get; set; }
        public double? Iva { get; set; }
        public double? Bruto { get; set; }
        public double? Comision { get; set; }
        public int? Codmoneda { get; set; }

        public virtual Vendedore CodvendedorNavigation { get; set; } = null!;
    }
}
