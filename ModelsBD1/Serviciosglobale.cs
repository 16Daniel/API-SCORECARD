using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Serviciosglobale
    {
        public Serviciosglobale()
        {
            Hcuposservicios = new HashSet<Hcuposservicio>();
            Resultadosglobalesservicios = new HashSet<Resultadosglobalesservicio>();
            Serviciosglobalescomentarios = new HashSet<Serviciosglobalescomentario>();
        }

        public int Codservicio { get; set; }
        public string? Nombre { get; set; }
        public string? Nombrecorto { get; set; }
        public byte[] Version { get; set; } = null!;
        public int Gruporecursos { get; set; }

        public virtual ICollection<Hcuposservicio> Hcuposservicios { get; set; }
        public virtual ICollection<Resultadosglobalesservicio> Resultadosglobalesservicios { get; set; }
        public virtual ICollection<Serviciosglobalescomentario> Serviciosglobalescomentarios { get; set; }
    }
}
