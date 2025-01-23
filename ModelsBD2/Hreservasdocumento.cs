using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreservasdocumento
    {
        public int Cod { get; set; }
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public string Ruta { get; set; } = null!;

        public virtual Hreservascab Hreservascab { get; set; } = null!;
    }
}
