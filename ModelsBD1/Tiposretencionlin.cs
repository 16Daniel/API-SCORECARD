using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tiposretencionlin
    {
        public int Tipo { get; set; }
        public int Numlin { get; set; }
        public int? RegimretArtic { get; set; }
        public string? RegimretCliprov { get; set; }
        public double? Porcretencion { get; set; }
        public double? Pagominimo { get; set; }
        public double? Montosinretencion { get; set; }
        public int? Aplicadosobre { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }

        public virtual Tiposretencion TipoNavigation { get; set; } = null!;
    }
}
