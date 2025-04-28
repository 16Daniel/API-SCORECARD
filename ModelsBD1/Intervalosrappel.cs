using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Intervalosrappel
    {
        public int Codproveedor { get; set; }
        public int Codrappel { get; set; }
        public int Codintervalo { get; set; }
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public double Valor { get; set; }

        public virtual Rappelsproveedore Cod { get; set; } = null!;
    }
}
