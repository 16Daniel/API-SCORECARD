using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class EstadisticaConfig
    {
        public int Idinforme { get; set; }
        public int Codusuario { get; set; }
        public byte[]? Report { get; set; }
        public byte[]? Columns { get; set; }
        public byte[]? Styles { get; set; }

        public virtual Informe IdinformeNavigation { get; set; } = null!;
    }
}
