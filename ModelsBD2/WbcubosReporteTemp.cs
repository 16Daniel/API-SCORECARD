using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class WbcubosReporteTemp
    {
        public int Id { get; set; }
        public string? Fecha { get; set; }
        public string? Grupo { get; set; }
        public string? Ciudad { get; set; }
        public string? Jsondata { get; set; }
        public DateTime? Registro { get; set; }
        public int? Detallesdelivery { get; set; }
    }
}
