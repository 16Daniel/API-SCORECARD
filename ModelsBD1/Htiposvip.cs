using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Htiposvip
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
    }
}
