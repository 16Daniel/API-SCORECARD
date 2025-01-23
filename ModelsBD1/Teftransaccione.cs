using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Teftransaccione
    {
        public string Origen { get; set; } = null!;
        public string Tipodocumento { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public short Posicion { get; set; }
        public string? Extdata { get; set; }
        public string? Firmadigital { get; set; }
        public string? Comprobante { get; set; }

        public virtual Tesorerium Tesorerium { get; set; } = null!;
    }
}
