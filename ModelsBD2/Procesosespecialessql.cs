using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Procesosespecialessql
    {
        public Procesosespecialessql()
        {
            Procesosespecialesparams = new HashSet<Procesosespecialesparam>();
        }

        public int Id { get; set; }
        public int Numsql { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Consulta { get; set; }
        public string? Sqldegestion { get; set; }

        public virtual Procesosespeciale IdNavigation { get; set; } = null!;
        public virtual ICollection<Procesosespecialesparam> Procesosespecialesparams { get; set; }
    }
}
