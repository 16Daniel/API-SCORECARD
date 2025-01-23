using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Asuntoscamposlibre
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }

        public virtual Asunto Asunto { get; set; } = null!;
    }
}
