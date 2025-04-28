using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Regimenret
    {
        public Regimenret()
        {
            Codarticulos = new HashSet<Articulo1>();
            CodarticulosNavigation = new HashSet<Articulo1>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Claveretarticulo { get; set; }

        public virtual ICollection<Articulo1> Codarticulos { get; set; }
        public virtual ICollection<Articulo1> CodarticulosNavigation { get; set; }
    }
}
