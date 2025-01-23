using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class NetTarjetaFidelizacion
    {
        public Guid IdTarjeta { get; set; }
        public string? Descripcion { get; set; }
        public string? InicioPista { get; set; }
        public string? SeparadorCampos { get; set; }
        public int? NumeroCampo { get; set; }
        public string? Mascara { get; set; }
        public bool? AplicarDescuento { get; set; }
        public bool? AplicarTarifa { get; set; }
        public bool? AplicarMedioPago { get; set; }
        public decimal? Descuento { get; set; }
        public int? IdTarifa { get; set; }
        public string? IdMedioPago { get; set; }
    }
}
