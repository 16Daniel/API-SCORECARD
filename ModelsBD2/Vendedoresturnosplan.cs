using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vendedoresturnosplan
    {
        public int Codvendedor { get; set; }
        public string Codalmacen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Codturno { get; set; }
    }
}
