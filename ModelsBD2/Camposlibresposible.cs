using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Camposlibresposible
    {
        public short Tabla { get; set; }
        public string Campo { get; set; } = null!;
        public short Posicion { get; set; }
        public string? Valor { get; set; }

        public virtual Camposlibresconfig Camposlibresconfig { get; set; } = null!;
    }
}
