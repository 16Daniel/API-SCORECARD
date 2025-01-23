using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class InventarioMensual
    {
        public int Id { get; set; }
        public int? Registro { get; set; }
        public int? City { get; set; }
        public int? Sucursal { get; set; }
        public int? Codarticulo { get; set; }
        public string Referencia { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Medida { get; set; } = null!;
        public decimal? Unidades { get; set; }
        public decimal? StockAnt { get; set; }
        public decimal? Diferencia { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? Date { get; set; }
        public bool Procesado { get; set; }
        public string? Tipo { get; set; }
        public int? Orden { get; set; }
    }
}
