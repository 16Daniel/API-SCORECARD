using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Regimenesfacturacion
    {
        public int Codigo { get; set; }
        public string? Descripcion { get; set; }
        public bool? Siempresinimpuestos { get; set; }
        public bool? Libroventas { get; set; }
        public bool? Librocompras { get; set; }
        public int? Orden { get; set; }
        public string Abreviacion { get; set; } = null!;
        public string Libroiva { get; set; } = null!;
        public string? Regimenasociado { get; set; }
    }
}
