using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Comisionescab
    {
        public Comisionescab()
        {
            Comisioneslins = new HashSet<Comisioneslin>();
            Comisionesporvendedors = new HashSet<Comisionesporvendedor>();
            Comisionesvendedors = new HashSet<Comisionesvendedor>();
            Rangos = new HashSet<Rango>();
        }

        public int Codcomision { get; set; }
        public string? Descripcion { get; set; }
        public string? Tipocomision { get; set; }
        public string? Modoaplicacion { get; set; }
        public string? Modocalculo { get; set; }
        public string? Ivaincluido { get; set; }

        public virtual ICollection<Comisioneslin> Comisioneslins { get; set; }
        public virtual ICollection<Comisionesporvendedor> Comisionesporvendedors { get; set; }
        public virtual ICollection<Comisionesvendedor> Comisionesvendedors { get; set; }
        public virtual ICollection<Rango> Rangos { get; set; }
    }
}
