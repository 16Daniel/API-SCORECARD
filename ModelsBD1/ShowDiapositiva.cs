using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ShowDiapositiva
    {
        public ShowDiapositiva()
        {
            ShowDiapositivagrupos = new HashSet<ShowDiapositivagrupo>();
            ShowDiapositivaspresentacions = new HashSet<ShowDiapositivaspresentacion>();
            ShowItems = new HashSet<ShowItem>();
        }

        public int Iddiapositiva { get; set; }
        public int? Duracion { get; set; }
        public int? Tipotransicion { get; set; }
        public int? Colorfondo { get; set; }
        public byte[]? Thumb { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<ShowDiapositivagrupo> ShowDiapositivagrupos { get; set; }
        public virtual ICollection<ShowDiapositivaspresentacion> ShowDiapositivaspresentacions { get; set; }
        public virtual ICollection<ShowItem> ShowItems { get; set; }
    }
}
