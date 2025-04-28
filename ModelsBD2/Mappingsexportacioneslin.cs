using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mappingsexportacioneslin
    {
        public int Idexportacion { get; set; }
        public string Clave { get; set; } = null!;

        public virtual Mappingsexportacionescab IdexportacionNavigation { get; set; } = null!;
    }
}
