using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItUsuario
    {
        public int Codusuario { get; set; }
        public string Password { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? Notas { get; set; }
    }
}
