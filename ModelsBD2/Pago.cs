using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pago
    {
        public string Caja { get; set; } = null!;
        public int Tipo { get; set; }
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Codvendedor { get; set; }
        public double? Importe { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factor { get; set; }
        public string? Comentario { get; set; }
        public int? Z { get; set; }
        public string? Codmediopago { get; set; }
        public string? Cuentadepagos { get; set; }
        public int? Codconceptopago { get; set; }
        public string? Cuentadegastos { get; set; }
        public int? Estado { get; set; }
        public int? Idhotel { get; set; }
        public string? Seriereserva { get; set; }
        public int? Idreserva { get; set; }
        public int? Planta { get; set; }
        public int? Habitacion { get; set; }
        public string? Cajadevuelta { get; set; }
        public int? Numerodevuelto { get; set; }
        public double? Comisioncambio { get; set; }
        public string? Cuentaingreso { get; set; }
        public int? Zingreso { get; set; }
        public string? Cajaingreso { get; set; }
        public short? Tipomovcaja { get; set; }
        public string Cajaorigen { get; set; } = null!;
        public bool Devuelto { get; set; }
        public string? Origen { get; set; }
        public int? Numsalidas { get; set; }
        public string? Seriedoc { get; set; }
        public int? Numerodoc { get; set; }
        public string? Ndoc { get; set; }
        public string? Nif { get; set; }
        public string? Nombre { get; set; }
    }
}
