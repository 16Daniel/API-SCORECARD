using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Htiposbloqueo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Tipo { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public byte[]? Version { get; set; }
    }
}
