using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Facturasventacliente
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public long? Id { get; set; }
        public string? Nif { get; set; }
        public string? Nombre { get; set; }
        public bool? Noaplicarimpuestos { get; set; }
        public string? Profesion { get; set; }
        public string? Taxoffice { get; set; }
        public string? Direccion { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Codigopostal { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Tarjetafidelizacion { get; set; }
        public string? Clientetarjeta { get; set; }
        public string? Fechacaducidadtarjeta { get; set; }
        public bool? Devolivaboxvel { get; set; }
        public DateTime? Fechaenvioboxvel { get; set; }
        public string? Codpais { get; set; }
        public string? Descpais { get; set; }
        public string? Docidglobalblue { get; set; }

        public virtual Facturasventum NNavigation { get; set; } = null!;
    }
}
