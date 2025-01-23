using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class SpContacto
    {
        public int Codcliente { get; set; }
        public string? Nombrecliente { get; set; }
        public string? Empresa { get; set; }
        public string? Direccion1 { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Telefono1 { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string Tiporeg { get; set; } = null!;
        public string? Descatalogado { get; set; }
        public int? Codvisible { get; set; }
        public string? Mobil { get; set; }
        public string Cargo { get; set; } = null!;
    }
}
