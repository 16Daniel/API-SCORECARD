using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Vendedorescategorium
    {
        public int Codvendedor { get; set; }
        public string? Nomvendedor { get; set; }
        public string? Provincia { get; set; }
        public string? Poblacion { get; set; }
        public string? Centro { get; set; }
        public string? Categoria { get; set; }
        public string? Descatalogado { get; set; }
        public string? Newpassentrada { get; set; }
        public int? Visibilidad { get; set; }
    }
}
