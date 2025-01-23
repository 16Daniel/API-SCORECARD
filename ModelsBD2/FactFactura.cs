using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class FactFactura
    {
        public int IdFactura { get; set; }
        public string? IdCliente { get; set; }
        public string? IdEmpresa { get; set; }
        public string? IdTicket { get; set; }
        public string? IdSerie { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string? Condicion { get; set; }
        public double? IvaPorc { get; set; }
        public double? Descuento { get; set; }
        public double? Subtotal { get; set; }
        public double? Iva { get; set; }
        public double? Total { get; set; }
        public string? LeyendaPieFactura { get; set; }
        public string? Status { get; set; }
    }
}
