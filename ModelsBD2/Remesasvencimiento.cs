using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Remesasvencimiento
    {
        public int Numrem { get; set; }
        public string Origen { get; set; } = null!;
        public string Tipodocumento { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public short Posicion { get; set; }
        public DateTime? Fecharemesa { get; set; }
        public DateTime? Fechavencimiento { get; set; }
        public double? Importe { get; set; }
        public int? Codempresaconta { get; set; }
        public int? Ejercicio { get; set; }
        public int? Numeroremesa { get; set; }
        public int Numlin { get; set; }

        public virtual Remesa? NumeroremesaNavigation { get; set; }
        public virtual Tesorerium Tesorerium { get; set; } = null!;
    }
}
