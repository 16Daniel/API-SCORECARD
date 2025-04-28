using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tef
    {
        public Tef()
        {
            TefsConfigs = new HashSet<TefsConfig>();
            TefsParams = new HashSet<TefsParam>();
        }

        public int Idtef { get; set; }
        public string? Nombre { get; set; }
        public int Tipo { get; set; }

        public virtual ICollection<TefsConfig> TefsConfigs { get; set; }
        public virtual ICollection<TefsParam> TefsParams { get; set; }
    }
}
