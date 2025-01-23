using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Kit
    {
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int Lineakit { get; set; }
        public int Codartkit { get; set; }
        public string Tallakit { get; set; } = null!;
        public string Colorkit { get; set; } = null!;
        public string? Referencia { get; set; }
        public string? Descripciokit { get; set; }
        public string? Referenciakit { get; set; }
        public double? Unidades { get; set; }
        public double? Preciounidad { get; set; }
        public double? Totallinea { get; set; }
        public string? Imprimirlinea { get; set; }
        public double? Unidades2 { get; set; }
        public string? Comentario { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
