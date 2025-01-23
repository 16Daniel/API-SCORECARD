using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Almacen
    {
        public Almacen()
        {
            Gruposalmacenlins = new HashSet<Gruposalmacenlin>();
            Mermascabs = new HashSet<Mermascab>();
            Tarifascompras = new HashSet<Tarifascompra>();
        }

        public string Codalmacen { get; set; } = null!;
        public string? Nombrealmacen { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Notas { get; set; }
        public string? N { get; set; }
        public string? Centrocoste { get; set; }
        public double? Stockminimo { get; set; }
        public double? Stockmaximo { get; set; }
        public double? Factor { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Serietraspasos { get; set; }
        public int? Codempresacontable { get; set; }
        public int? Valoraciontraspasos { get; set; }
        public int? Valoracioninventario { get; set; }
        public int? Pvpetiquetas { get; set; }
        public string? Poperacional { get; set; }
        public int? Codcliente { get; set; }
        public DateTime? Fechaultrep { get; set; }
        public byte[]? Version { get; set; }
        public DateTime? Ultfacturacionprestamos { get; set; }
        public DateTime? Fechabloqueo { get; set; }
        public int? Valoracionconsumos { get; set; }
        public int? Valoraciontraspasosdmn { get; set; }
        public int? Valoracioninventariosdmn { get; set; }
        public bool? Esmermas { get; set; }
        public bool Esplanificacion { get; set; }
        public string? Email { get; set; }
        public DateTime Horacambioturno { get; set; }
        public string? Codpostal { get; set; }
        public string? Codpais { get; set; }
        public string? Serietraspasostranporte { get; set; }

        public virtual ICollection<Gruposalmacenlin> Gruposalmacenlins { get; set; }
        public virtual ICollection<Mermascab> Mermascabs { get; set; }

        public virtual ICollection<Tarifascompra> Tarifascompras { get; set; }
    }
}
