using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ControlCambiosArticulo
    {
        public int Id { get; set; }
        public int? Idu { get; set; }
        public string? Jsondata { get; set; }
        public string? Justificacion { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? Activo { get; set; }
        public bool? Autorizado { get; set; }
        public string? Accion { get; set; }
    }
}
