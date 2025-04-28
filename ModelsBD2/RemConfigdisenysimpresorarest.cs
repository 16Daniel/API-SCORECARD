using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemConfigdisenysimpresorarest
    {
        public int Idfront { get; set; }
        public string Terminal { get; set; } = null!;
        public int Tipo { get; set; }
        public string? Impresora { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
