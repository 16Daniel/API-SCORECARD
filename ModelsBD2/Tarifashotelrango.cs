using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tarifashotelrango
    {
        public Tarifashotelrango()
        {
            Cargodtohotelprecios = new HashSet<Cargodtohotelprecio>();
            Dtosocupaciontemporada = new HashSet<Dtosocupaciontemporadum>();
            Precioshotels = new HashSet<Precioshotel>();
        }

        public int Idrango { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<Cargodtohotelprecio> Cargodtohotelprecios { get; set; }
        public virtual ICollection<Dtosocupaciontemporadum> Dtosocupaciontemporada { get; set; }
        public virtual ICollection<Precioshotel> Precioshotels { get; set; }
    }
}
