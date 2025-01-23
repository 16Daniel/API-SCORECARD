using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Arreglo
    {
        public int Tipodoc { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int Numlineacoment { get; set; }
        public int? Codcliente { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Descripcion { get; set; }
        public double? Unidades { get; set; }
        public double? Incprecio { get; set; }
        public double? Incprecioiva { get; set; }
        public DateTime? Fechaventa { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public DateTime? Fecharecogido { get; set; }
        public int? Estado { get; set; }
        public int? Codproveedor { get; set; }
        public string? Observaciones { get; set; }
        public int Id { get; set; }
        public int Idlin { get; set; }
        public double? Coste { get; set; }
        public int? Impuesto { get; set; }
        public int? Codarticuloint { get; set; }
        public string Tallaint { get; set; } = null!;
        public string Colorint { get; set; } = null!;
        public string? Almacen { get; set; }
    }
}
