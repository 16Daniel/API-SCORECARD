using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string ApellidoP { get; set; } = null!;
        public string ApellidoM { get; set; } = null!;
        public int IdRol { get; set; }
        public string Email { get; set; } = null!;
        public string Pass { get; set; } = null!;
    }
}
