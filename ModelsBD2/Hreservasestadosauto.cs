using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreservasestadosauto
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Codigo { get; set; }
        public string Idestado { get; set; } = null!;
        public bool? Poner { get; set; }
        public int Idlinea { get; set; }
        public int Idperiodo { get; set; }
        public bool? Espack { get; set; }

        public virtual Hreservascab Hreservascab { get; set; } = null!;
    }
}
