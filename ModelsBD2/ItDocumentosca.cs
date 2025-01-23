using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItDocumentosca
    {
        public string Numseriepc { get; set; } = null!;
        public int Numpedidoc { get; set; }
        public string Numserieac { get; set; } = null!;
        public int Numalbaranac { get; set; }
        public string Numseriepv { get; set; } = null!;
        public int Numpedidov { get; set; }
        public string Numserieav { get; set; } = null!;
        public int Numalbaranav { get; set; }
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string? Fechaalbaran { get; set; }
        public string? Fechaproceso { get; set; }
    }
}
