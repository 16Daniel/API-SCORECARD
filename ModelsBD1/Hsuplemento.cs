using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hsuplemento
    {
        public int Id { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public short? Tiposuplemento { get; set; }
        public short? Tipocalculo { get; set; }
        public short? Aplicable { get; set; }
        public string? Diasaplicable { get; set; }
        public short? Numdias { get; set; }
    }
}
