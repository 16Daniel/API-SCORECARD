using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Lugare
    {
        public string Codlugar { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Observaciones { get; set; }
        public byte[] Version { get; set; } = null!;
    }
}
