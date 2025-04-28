using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Persona
    {
        public string? Nombre { get; set; }
        public string Nif { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Nacionalidad { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public string? Lugarnacimiento { get; set; }
        public int? Idioma { get; set; }
        public string? Sexo { get; set; }
        public string? Modelo { get; set; }
        public string? Matricula { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Boleanos { get; set; }
        public string? Comentarios { get; set; }
        public int? Comunidadcod { get; set; }
        public int? Idtipodoc { get; set; }
        public string? Codpais { get; set; }
        public int? Codcliente { get; set; }
        public string? Direccion2 { get; set; }
        public string? Fax { get; set; }
        public string? Codpaisnacionalidad { get; set; }
        public string? Nombre1 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public DateTime? Fechaexpedicion { get; set; }
        public string? Numtarjeta { get; set; }
        public int? Tipotarjeta { get; set; }
        public string? Tarcaducidad { get; set; }
        public byte[]? Imagendoc { get; set; }
        public byte[]? Foto { get; set; }
        public int? Codigo { get; set; }
    }
}
