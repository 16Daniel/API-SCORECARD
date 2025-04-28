using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Grupoarticulo
    {
        public int Codgrupo { get; set; }
        public string? Nombregrupo { get; set; }
        public int? Coddpto { get; set; }
        public int? Codfamilia { get; set; }
        public int? Codsubfamilia { get; set; }
        public int? Codseccion { get; set; }
        public int? Codmarca { get; set; }
        public int? Codlinea { get; set; }
        public string? Referencia { get; set; }
        public string? Temporada { get; set; }
        public int? Codtipo { get; set; }
        public int? Operador { get; set; }
    }
}
