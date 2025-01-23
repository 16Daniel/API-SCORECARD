using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Resultadosgeneranservicio
    {
        public int Idtipoasunto { get; set; }
        public int Codservicio { get; set; }
        public int Codresultado { get; set; }
        public int Numlin { get; set; }
        public int? Idgenerar { get; set; }
        public int? Auto { get; set; }
        public int? Periodo { get; set; }
        public int? Fechareferencia { get; set; }
        public bool? Copiardoc { get; set; }
        public bool? Copiarobs { get; set; }
        public bool? Nofacturable { get; set; }
        public int? Minutos { get; set; }

        public virtual Resultadosglobalesservicio Resultadosglobalesservicio { get; set; } = null!;
    }
}
