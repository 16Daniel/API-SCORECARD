using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruporecurso
    {
        public Gruporecurso()
        {
            Codrecursos = new HashSet<Recursosempresa>();
        }

        public int Codgrupo { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Idtipoasunto { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Intervalo { get; set; }
        public int? Altura { get; set; }
        public int? Dias { get; set; }
        public DateTime? Horainicio { get; set; }
        public DateTime? Horafin { get; set; }

        public virtual ICollection<Recursosempresa> Codrecursos { get; set; }
    }
}
