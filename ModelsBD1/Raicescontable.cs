using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Raicescontable
    {
        public string Tipo { get; set; } = null!;
        public string? Subtipo { get; set; }
        public int? Contador { get; set; }
        public string? Titulo { get; set; }
        public string? Raiz { get; set; }
        public string? Origentesoreria { get; set; }
    }
}
