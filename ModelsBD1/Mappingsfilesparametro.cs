using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Mappingsfilesparametro
    {
        public int Idmap { get; set; }
        public int Idfile { get; set; }
        public int Numparam { get; set; }
        public string? Paramname { get; set; }
        public int? Paramtype { get; set; }
        public int? Paramsize { get; set; }
        public string? Paramvalue { get; set; }
        public string? Paramcaption { get; set; }

        public virtual Mappingsfile Id { get; set; } = null!;
    }
}
