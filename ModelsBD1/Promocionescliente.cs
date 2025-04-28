using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Promocionescliente
    {
        public int Codcliente { get; set; }
        public int Idpromocion { get; set; }
        public DateTime? Fechaimpresion { get; set; }
        public DateTime? Fechageneracion { get; set; }
        public double? Importedto { get; set; }
        public int Id { get; set; }
        public bool? Usado { get; set; }
        public string? Cupon { get; set; }
        public int? Front { get; set; }
        public DateTime? Fechaenvio { get; set; }
        public DateTime? Fechauso { get; set; }
        public DateTime? Horageneracion { get; set; }
    }
}
