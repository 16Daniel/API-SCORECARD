using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Almacenesnumempleado
    {
        public string Codalmacen { get; set; } = null!;
        public int Codusuario { get; set; }
        public int Codtipoempleado { get; set; }
        public int Codtipodia { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Numempleados { get; set; }
    }
}
