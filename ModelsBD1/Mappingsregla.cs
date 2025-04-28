using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Mappingsregla
    {
        public int Idmap { get; set; }
        public int Modo { get; set; }
        public int Idregla { get; set; }
        public int? Posicion { get; set; }
        public string? Campodestino { get; set; }
        public string? Regla { get; set; }

        public virtual Mappingscab IdmapNavigation { get; set; } = null!;
    }
}
