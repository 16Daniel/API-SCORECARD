using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vencimfpago
    {
        public string Codformapago { get; set; } = null!;
        public short Numvencim { get; set; }
        public int? Dias { get; set; }
        public double? Porcentaje { get; set; }
        public string? Gentesoreria { get; set; }
        public string? Codtipopago { get; set; }
        public string? Cuentacobro { get; set; }
        public string? Cuentapago { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Formaspago CodformapagoNavigation { get; set; } = null!;
        public virtual Tipospago? CodtipopagoNavigation { get; set; }
    }
}
