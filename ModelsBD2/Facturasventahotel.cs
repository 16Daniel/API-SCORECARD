using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Facturasventahotel
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public string? Reserva { get; set; }
        public string? Sureserva { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public string? Grupoocupante { get; set; }
        public string? Captionhabitacion { get; set; }
        public int? Pax { get; set; }
        public int? Paxnen { get; set; }
        public int? Paxbebe { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Descripcion { get; set; }
        public double? Unidades { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public double? Precioiva { get; set; }
        public int? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Importe { get; set; }
        public double? Importeiva { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Codalmacen { get; set; }
        public int? Dpto { get; set; }
        public int? Seccion { get; set; }
        public int? Idhotel { get; set; }
        public string? Serie { get; set; }
        public int? Idreserva { get; set; }
        public string? Actividad { get; set; }

        public virtual Facturasventum NNavigation { get; set; } = null!;
    }
}
