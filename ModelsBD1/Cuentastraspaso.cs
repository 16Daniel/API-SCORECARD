using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cuentastraspaso
    {
        public string Nombreconfiguracion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Cuentagrupo67 { get; set; }
        public string? Cuentaiva { get; set; }
        public string? Cuentare { get; set; }
        public string? Cuentadtopp { get; set; }
        public short? Concepto { get; set; }
        public string? Comentario { get; set; }
        public string? Comentariogastos { get; set; }
        public string? Cuentacompras { get; set; }
        public string? Cuentacosteventas { get; set; }
    }
}
