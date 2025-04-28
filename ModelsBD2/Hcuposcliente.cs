using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hcuposcliente
    {
        public int Idhotel { get; set; }
        public int Idcupo { get; set; }
        public int Codcliente { get; set; }
        public int Posicion { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
