using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Motivosdescuadre
    {
        public int Idmotivo { get; set; }
        public string? Descripcion { get; set; }
        public byte[] Version { get; set; } = null!;
    }
}
