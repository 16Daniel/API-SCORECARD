using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pasarelapago
    {
        public int Idpasarela { get; set; }
        public string? Descripcion { get; set; }
        public int? Tipo { get; set; }
        public string? Url { get; set; }
        public string? Codcomercio { get; set; }
        public string? Titularcomercio { get; set; }
        public string? Nombrecomercio { get; set; }
        public string? Terminal { get; set; }
        public string? Clave { get; set; }
        public string? Urlrespuesta { get; set; }
        public string? Urlok { get; set; }
        public string? Urlko { get; set; }
        public string? Clavedescarga { get; set; }
        public string? Caja { get; set; }
    }
}
