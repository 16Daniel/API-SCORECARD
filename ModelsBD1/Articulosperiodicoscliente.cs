using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articulosperiodicoscliente
    {
        public int Codcliente { get; set; }
        public int Numlinea { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public int Codarticulo { get; set; }
        public string? Serie { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Precio { get; set; }
        public double? Uds { get; set; }
        public double? Dto { get; set; }
        public int? Diafacturacion { get; set; }
        public DateTime? Fechasiguiente { get; set; }
        public int Codmoneda { get; set; }
        public int? Cadaxmeses { get; set; }
        public DateTime? Fechaalta { get; set; }
        public DateTime? Fechabaja { get; set; }
        public string? Almacen { get; set; }
        public string? Supedido { get; set; }
        public int? Codenvio { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
    }
}
