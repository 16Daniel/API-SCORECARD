using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class ItMerma
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public double? Unidades { get; set; }
        public double? Precio { get; set; }
        public string Justificacion { get; set; } = null!;
        public string Comentarios { get; set; } = null!;
        public string? Usuario { get; set; }
        public string Sucursal { get; set; } = null!;
    }
}
