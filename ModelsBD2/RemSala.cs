using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemSala
    {
        public RemSala()
        {
            RemConfigsalas = new HashSet<RemConfigsala>();
        }

        public int Idfront { get; set; }
        public short Sala { get; set; }
        public string? Nombre { get; set; }
        public bool? Desactmesas { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
        public virtual ICollection<RemConfigsala> RemConfigsalas { get; set; }
    }
}
