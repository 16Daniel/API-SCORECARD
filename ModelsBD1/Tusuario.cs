using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tusuario
    {
        public string IdEmpleado { get; set; } = null!;
        public string? Nombre { get; set; }
        public int? Contraseña { get; set; }
        public int? Acceso { get; set; }
        public int? Status { get; set; }
    }
}
