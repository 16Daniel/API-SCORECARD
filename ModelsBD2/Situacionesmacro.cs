using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Situacionesmacro
    {
        public int Codmacro { get; set; }
        public int Codsituacion { get; set; }

        public virtual Situacione CodsituacionNavigation { get; set; } = null!;
    }
}
