using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class RhRegionalesHistorial
    {
        public int Id { get; set; }
        public string? Regional { get; set; }
        public string? Sucursal { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Entrada { get; set; }
        public string? Salida { get; set; }
        public string? Estadia { get; set; }
        public string? Status { get; set; }
    }
}
