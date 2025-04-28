using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemFrontsterminale
    {
        public int Idfront { get; set; }
        public string Nombreterminal { get; set; } = null!;
        public string Siglas { get; set; } = null!;
        public string Licencia { get; set; } = null!;
        public string Hardware { get; set; } = null!;
        public string? Esservidorclaves { get; set; }
        public DateTime? Caducidad { get; set; }
        public int? Numusuarios { get; set; }
        public int? Majorversion { get; set; }
        public int? Minorversion { get; set; }
        public string? Usuarioremote { get; set; }
        public string? Passwordremote { get; set; }
        public string? Caja { get; set; }
        public int? Codtipoterminal { get; set; }
        public string? Databasegeneral { get; set; }
        public string? Databasegestion { get; set; }
        public DateTime? Ultimaactualizacion { get; set; }
        public int? Estadoftp { get; set; }
        public string? Errordescargaftp { get; set; }
        public int? Idprograma { get; set; }
        public string? Ipremote { get; set; }
        public int? Puertoremote { get; set; }
        public string? Actualizadook { get; set; }
        public string? Actualizadookgeneral { get; set; }
        public string? Actualizadookcontab { get; set; }
        public string? Ismainsiglas { get; set; }
        public int? Numentradas { get; set; }
        public int? Plugginestadoftp { get; set; }
        public string? Plugginerrordescargaftp { get; set; }
        public DateTime? Fechaactualizacion { get; set; }
        public DateTime? Horaactualizacion { get; set; }
    }
}
