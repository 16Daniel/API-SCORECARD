using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class HoperacionesDispositivo
    {
        public int Id { get; set; }
        public int? Iddispositivo { get; set; }
        public int? Idoperacion { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public string? Extension { get; set; }
        public string? Parametro1 { get; set; }
        public string? Parametro2 { get; set; }
        public string? Parametro3 { get; set; }
    }
}
