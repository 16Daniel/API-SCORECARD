using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruposarticulo
    {
        public Gruposarticulo()
        {
            Condicionesgruposarticulos = new HashSet<Condicionesgruposarticulo>();
            ShowDiapositivagrupos = new HashSet<ShowDiapositivagrupo>();
        }

        public int Idgrupo { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }
        public int? Codvisible { get; set; }

        public virtual ICollection<Condicionesgruposarticulo> Condicionesgruposarticulos { get; set; }
        public virtual ICollection<ShowDiapositivagrupo> ShowDiapositivagrupos { get; set; }
    }
}
