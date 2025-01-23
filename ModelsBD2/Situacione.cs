using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Situacione
    {
        public Situacione()
        {
            Situacionesarticulos = new HashSet<Situacionesarticulo>();
            Situacionesfamilia = new HashSet<Situacionesfamilium>();
            Situacionesmacros = new HashSet<Situacionesmacro>();
        }

        public int Codsituacion { get; set; }
        public string? Descripcion { get; set; }
        public string? Impresionvalorada { get; set; }
        public string? Alternativa { get; set; }
        public int? Sitalternativa { get; set; }

        public virtual ICollection<Situacionesarticulo> Situacionesarticulos { get; set; }
        public virtual ICollection<Situacionesfamilium> Situacionesfamilia { get; set; }
        public virtual ICollection<Situacionesmacro> Situacionesmacros { get; set; }
    }
}
