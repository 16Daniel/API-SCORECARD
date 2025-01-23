using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Servicio
    {
        public Servicio()
        {
            Serviciosarticulos = new HashSet<Serviciosarticulo>();
            Serviciosdocumentos = new HashSet<Serviciosdocumento>();
            Serviciosparada = new HashSet<Serviciosparada>();
            Codrecursos = new HashSet<Recursosempresa>();
        }

        public double Idintervencion { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int? Codempleado { get; set; }
        public string? Asignado { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Estado { get; set; }
        public string? Titulo { get; set; }
        public string? Observaciones { get; set; }
        public string? Bhorafija { get; set; }
        public DateTime? Fechamodificacion { get; set; }
        public int? Duracion { get; set; }
        public int? Duracionprevista { get; set; }
        public string? Horainicio { get; set; }
        public string? Horafin { get; set; }
        public string? Horaprevista { get; set; }
        public string Seriealbaran { get; set; } = null!;
        public int? Numeroalbaran { get; set; }
        public string? Nalbaran { get; set; }
        public int? Tipodoc { get; set; }
        public int? Codcondicion { get; set; }
        public int? Codtransporte { get; set; }
        public double? Kms { get; set; }
        public int? Codtarifa { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int? Codpredefinido { get; set; }
        public int? Codresultado { get; set; }
        public int? Modofact { get; set; }
        public int? Coddesplaza { get; set; }
        public string Talladesplaza { get; set; } = null!;
        public string Colordesplaza { get; set; } = null!;
        public double? Duraciontotal { get; set; }
        public double? Paradas { get; set; }
        public double? Duracionreal { get; set; }
        public double? Importemo { get; set; }
        public double? Importemoiva { get; set; }
        public double? Importedesp { get; set; }
        public double? Importedespiva { get; set; }
        public double? Importeart { get; set; }
        public double? Importeartiva { get; set; }
        public int? Tienedesp { get; set; }
        public double? Manoobraafacturar { get; set; }
        public double? Despafacturar { get; set; }
        public int? Codvehiculo { get; set; }
        public string? Bloqueado { get; set; }
        public string? Bloquea { get; set; }
        public string? Seriebloc { get; set; }
        public int? Numbloc { get; set; }
        public int? Idserbloc { get; set; }
        public int? Tiposervicio { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factor { get; set; }
        public double? Costearticulos { get; set; }
        public double? Costedesplaza { get; set; }
        public double? Costemanoobra { get; set; }
        public double? Costegastos { get; set; }
        public int? Unitario { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public double? Costearticulosiva { get; set; }
        public double? Costedesplazaiva { get; set; }
        public double? Costemanoobraiva { get; set; }
        public double? Costegastosiva { get; set; }
        public int? Numeroasociado { get; set; }
        public string? Serieasociado { get; set; }
        public int? Estadoreserva { get; set; }
        public int? Pax { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Codcreador { get; set; }
        public int? Codcliente { get; set; }
        public int? Facturara { get; set; }
        public string? Caja { get; set; }
        public bool? Anuladopaquete { get; set; }
        public double? Idparent { get; set; }

        public virtual Asunto Asunto { get; set; } = null!;
        public virtual Servicioscamposlibre? Servicioscamposlibre { get; set; }
        public virtual ICollection<Serviciosarticulo> Serviciosarticulos { get; set; }
        public virtual ICollection<Serviciosdocumento> Serviciosdocumentos { get; set; }
        public virtual ICollection<Serviciosparada> Serviciosparada { get; set; }

        public virtual ICollection<Recursosempresa> Codrecursos { get; set; }
    }
}
