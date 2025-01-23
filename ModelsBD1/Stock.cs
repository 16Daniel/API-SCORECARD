using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Stock
    {
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Codalmacen { get; set; } = null!;
        public double? Stock1 { get; set; }
        public double? Pedido { get; set; }
        public double? Aservir { get; set; }
        public double? Prestado { get; set; }
        public double? Deposito { get; set; }
        public double? Fabricacion { get; set; }
        public double? Minimo { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public double? Maximo { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime? Fecharegul { get; set; }
        public double? Stockregul { get; set; }
        public double? Enreparacion { get; set; }
        public double? Entransito { get; set; }
        public double? Merma { get; set; }
        public double? Stockcontable { get; set; }
        public double? Stock2 { get; set; }
        public double? Stockregul2 { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
