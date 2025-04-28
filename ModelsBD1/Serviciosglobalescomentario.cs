using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Serviciosglobalescomentario
    {
        public int Codservicio { get; set; }
        public int Numcomentario { get; set; }
        public int? Codidioma { get; set; }
        public string? Comentario { get; set; }

        public virtual Serviciosglobale CodservicioNavigation { get; set; } = null!;
    }
}
