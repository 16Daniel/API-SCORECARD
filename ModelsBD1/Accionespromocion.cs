using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Accionespromocion
    {
        public Accionespromocion()
        {
            Accionespromocionlins = new HashSet<Accionespromocionlin>();
        }

        public int Idpromocion { get; set; }
        public int Idaccion { get; set; }
        public int? Tipoaccion { get; set; }
        public string? Valor { get; set; }

        public virtual Promocione IdpromocionNavigation { get; set; } = null!;
        public virtual ICollection<Accionespromocionlin> Accionespromocionlins { get; set; }
    }
}
