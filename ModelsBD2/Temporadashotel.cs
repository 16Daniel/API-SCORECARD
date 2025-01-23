using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Temporadashotel
    {
        public Temporadashotel()
        {
            Cargodtohotelprecios = new HashSet<Cargodtohotelprecio>();
            Dtosocupaciontemporada = new HashSet<Dtosocupaciontemporadum>();
            Hotelestarifasextras = new HashSet<Hotelestarifasextra>();
            Precioshoteldia = new HashSet<Precioshoteldium>();
            Precioshotels = new HashSet<Precioshotel>();
            Tarifashotelcalendariodefectos = new HashSet<Tarifashotelcalendariodefecto>();
            Tarifashotelcalendarios = new HashSet<Tarifashotelcalendario>();
            Tarifashoteltemporada = new HashSet<Tarifashoteltemporada>();
            Temporadasdia = new HashSet<Temporadasdium>();
            Temporadaslins = new HashSet<Temporadaslin>();
        }

        public int Idtemporada { get; set; }
        public string? Descripcion { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<Cargodtohotelprecio> Cargodtohotelprecios { get; set; }
        public virtual ICollection<Dtosocupaciontemporadum> Dtosocupaciontemporada { get; set; }
        public virtual ICollection<Hotelestarifasextra> Hotelestarifasextras { get; set; }
        public virtual ICollection<Precioshoteldium> Precioshoteldia { get; set; }
        public virtual ICollection<Precioshotel> Precioshotels { get; set; }
        public virtual ICollection<Tarifashotelcalendariodefecto> Tarifashotelcalendariodefectos { get; set; }
        public virtual ICollection<Tarifashotelcalendario> Tarifashotelcalendarios { get; set; }
        public virtual ICollection<Tarifashoteltemporada> Tarifashoteltemporada { get; set; }
        public virtual ICollection<Temporadasdium> Temporadasdia { get; set; }
        public virtual ICollection<Temporadaslin> Temporadaslins { get; set; }
    }
}
