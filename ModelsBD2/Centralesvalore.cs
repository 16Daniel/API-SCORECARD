using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Centralesvalore
    {
        public int Idcentral { get; set; }
        public int Idpermiso { get; set; }
        public int Orden { get; set; }
        public string? Valor { get; set; }

        public virtual Centralespermiso Id { get; set; } = null!;
    }
}
