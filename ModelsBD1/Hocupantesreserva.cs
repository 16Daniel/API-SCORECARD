using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hocupantesreserva
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Orden { get; set; }
        public string? Nompersona { get; set; }
        public string? Nombre1 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? Nif20 { get; set; }
        public int? Idregistro { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public int? Edad { get; set; }
        public bool? Adulto { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public bool? Recibirinformacion { get; set; }
        public int? Aplicartasaturistica { get; set; }
        public string? Direccion { get; set; }
        public string? Direccion2 { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public string? Lugarnacimiento { get; set; }
        public int? Idioma { get; set; }
        public string? Sexo { get; set; }
        public string? Modelo { get; set; }
        public string? Matricula { get; set; }
        public string? Comentarios { get; set; }
        public int? Comunidadcod { get; set; }
        public int? Idtipodoc { get; set; }
        public string? Codpais { get; set; }
        public int? Codcliente { get; set; }
        public string? Codpaisnacionalidad { get; set; }
        public DateTime? Fechaexpedicion { get; set; }
        public string? Numtarjeta { get; set; }
        public int? Tipotarjeta { get; set; }
        public string? Tarcaducidad { get; set; }
        public string? Cvc { get; set; }
        public DateTime? Fechacaducidaddoc { get; set; }
        public int? Clientevip { get; set; }
        public string? Telefono2 { get; set; }

        public virtual Hreserva Hreserva { get; set; } = null!;
    }
}
