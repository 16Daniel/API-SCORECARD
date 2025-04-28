using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Comunicacionlog
    {
        public Comunicacionlog()
        {
            Lineascomunicacionlogs = new HashSet<Lineascomunicacionlog>();
            Logzsafacturars = new HashSet<Logzsafacturar>();
        }

        public int Idfront { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTime Fechahoraini { get; set; }
        public string? Cms { get; set; }
        public DateTime? Fechahoracms { get; set; }
        public int? Estado { get; set; }
        public string? Comprimidodesc { get; set; }
        public string Contenido { get; set; } = null!;
        public string Realizado { get; set; } = null!;
        public string? Automatico { get; set; }
        public string? Enviado { get; set; }

        public virtual ICollection<Lineascomunicacionlog> Lineascomunicacionlogs { get; set; }
        public virtual ICollection<Logzsafacturar> Logzsafacturars { get; set; }
    }
}
