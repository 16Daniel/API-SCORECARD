using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Esquematraspaso
    {
        public string Configuracion { get; set; } = null!;
        public string Esquema { get; set; } = null!;
        public short Linea { get; set; }
        public string? Clavecuentastraspaso { get; set; }
        public string? Opcional { get; set; }
        public string? Cuenta { get; set; }
        public string? Concepto { get; set; }
        public string? Comentario { get; set; }
        public string? Debe { get; set; }
        public string? Haber { get; set; }
        public string? Libroiva { get; set; }
    }
}
