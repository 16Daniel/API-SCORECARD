using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class FactUsuario
    {
        public string Id { get; set; } = null!;
        public string? NombreUsuario { get; set; }
        public string? Password { get; set; }
    }
}
