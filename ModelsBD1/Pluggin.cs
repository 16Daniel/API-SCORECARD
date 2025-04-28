using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pluggin
    {
        public int Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? Comando { get; set; }
        public string? Filenamexml { get; set; }
        public int? Cuando { get; set; }
        public byte[]? Version { get; set; }
    }
}
