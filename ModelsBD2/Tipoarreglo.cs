using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tipoarreglo
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public double? Precio { get; set; }
        public int? Impuesto { get; set; }
        public double? Coste { get; set; }
        public string? Cobrarporanticipado { get; set; }
    }
}
