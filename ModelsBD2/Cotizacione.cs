using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Cotizacione
    {
        public DateTime Fecha { get; set; }
        public int Codmoneda { get; set; }
        public double Cotizacion { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Moneda CodmonedaNavigation { get; set; } = null!;
    }
}
