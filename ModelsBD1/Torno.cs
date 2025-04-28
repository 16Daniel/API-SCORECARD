using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Torno
    {
        public int Idtorno { get; set; }
        public int Idfront { get; set; }
        public string? Descripcion { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
        public int? Puertoremoto { get; set; }
        public int? Puertolocal { get; set; }
        public byte[]? Version { get; set; }
    }
}
