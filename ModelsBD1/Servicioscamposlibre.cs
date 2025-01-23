using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Servicioscamposlibre
    {
        public double Idintervencion { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }

        public virtual Servicio Servicio { get; set; } = null!;
    }
}
