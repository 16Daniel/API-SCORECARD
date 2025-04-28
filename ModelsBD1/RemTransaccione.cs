using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemTransaccione
    {
        public int Id { get; set; }
        public string? Terminal { get; set; }
        public string? Caja { get; set; }
        public int? Cajanum { get; set; }
        public int? Z { get; set; }
        public short? Tipo { get; set; }
        public short? Accion { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public string? N { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Fo { get; set; }
        public int? Idcentral { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Codigostr { get; set; }
        public int? Subtipo { get; set; }
        public DateTime? Fecha2 { get; set; }
        public DateTime? Fecha3 { get; set; }
        public bool? Campobit { get; set; }
        public int? Numero2 { get; set; }
    }
}
