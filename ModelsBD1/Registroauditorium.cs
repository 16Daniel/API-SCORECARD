using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Registroauditorium
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Tipo { get; set; }
        public int? Codempleado { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public string? N { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Descripcion { get; set; }
        public double? Uds { get; set; }
        public double? Precio { get; set; }
        public double? Precioiva { get; set; }
        public int? Z { get; set; }
        public string? Cajastr { get; set; }
        public int? Cajaint { get; set; }
        public short? Sala { get; set; }
        public short? Mesa { get; set; }
        public double? Precio2 { get; set; }
        public int? Codmoneda { get; set; }
        public bool? Vienedefront { get; set; }
    }
}
