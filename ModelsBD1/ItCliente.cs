using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ItCliente
    {
        public string Rfc { get; set; } = null!;
        public string? Nombrecliente { get; set; }
        public string? Calle { get; set; }
        public string? Noext { get; set; }
        public string? Noint { get; set; }
        public string? Colonia { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public string? Codpostal { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Telefono2 { get; set; }
        public string? Uso { get; set; }
    }
}
