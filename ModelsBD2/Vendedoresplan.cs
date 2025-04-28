using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vendedoresplan
    {
        public int Codvendedor { get; set; }
        public string Codalmacen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Codcategoria { get; set; }
        public int? Codturno { get; set; }
    }
}
