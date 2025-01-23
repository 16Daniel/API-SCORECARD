using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiquetspag
    {
        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int? Codformapago { get; set; }
        public int? Codmoneda { get; set; }
        public double? Importe { get; set; }
        public double? Importe2 { get; set; }
        public double? Entregado { get; set; }
        public double? Cambio { get; set; }
        public double? Cambio2 { get; set; }
        public double? Propina { get; set; }
        public double? Beneficio { get; set; }
        public double? Pendiente { get; set; }
        public DateTime? Fechavencim { get; set; }

        public virtual Ticketscab Ticketscab { get; set; } = null!;
        public virtual Tiquetscab Tiquetscab { get; set; } = null!;
    }
}
