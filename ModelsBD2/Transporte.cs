using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Transporte
    {
        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }
        public string? Poperacional { get; set; }
        public string? Nif20 { get; set; }
        public string? Regimfact { get; set; }
    }
}
