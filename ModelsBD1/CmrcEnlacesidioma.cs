using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class CmrcEnlacesidioma
    {
        public int Idenlace { get; set; }
        public int Ididioma { get; set; }
        public string? Titulo { get; set; }

        public virtual CmrcEnlace IdenlaceNavigation { get; set; } = null!;
    }
}
