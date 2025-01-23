using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemSqlsfront
    {
        public int Idsql { get; set; }
        public int Idfront { get; set; }
        public string? Textosql { get; set; }
        public bool? Realizada { get; set; }
        public DateTime? Fechaejecucion { get; set; }
        public bool? Resultado { get; set; }
        public string? Mensaje { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
