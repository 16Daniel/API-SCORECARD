using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemListasfrontsdetalle
    {
        public int Idfront { get; set; }
        public int Tipo { get; set; }
        public int Codigo { get; set; }
        public int Subtipo { get; set; }
        public string Codigostr { get; set; } = null!;

        public virtual RemListasfront RemListasfront { get; set; } = null!;
    }
}
