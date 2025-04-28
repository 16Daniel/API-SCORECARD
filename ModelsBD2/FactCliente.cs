using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class FactCliente
    {
        public string Id { get; set; } = null!;
        public string? NombreFiscal { get; set; }
        public string? Calle { get; set; }
        public string? Colonia { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Localidad { get; set; }
        public string? Estado { get; set; }
        public string? Rfc { get; set; }
        public string? NoExterior { get; set; }
        public string? NoInterior { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Banco { get; set; }
        public string? NumCuenta { get; set; }
        public string? TipoTransaccion { get; set; }
    }
}
