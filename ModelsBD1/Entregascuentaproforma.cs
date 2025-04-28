using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Entregascuentaproforma
    {
        public string Origen { get; set; } = null!;
        public string Tipodocumento { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public short Posicion { get; set; }
        public string? Comentario { get; set; }
        public string? Terminal { get; set; }
    }
}
