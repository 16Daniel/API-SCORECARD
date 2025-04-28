using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tiposretencionclave
    {
        public Tiposretencionclave()
        {
            Tiposretencions = new HashSet<Tiposretencion>();
        }

        public int Id { get; set; }
        public string Clave { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Tiposretencion> Tiposretencions { get; set; }
    }
}
