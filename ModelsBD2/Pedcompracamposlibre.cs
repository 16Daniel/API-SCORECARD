using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pedcompracamposlibre
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public string? Generado { get; set; }
        public string? Documento { get; set; }
        public string? Numero { get; set; }
        public string? Sucursal { get; set; }

        public virtual Pedcompracab NNavigation { get; set; } = null!;
    }
}
