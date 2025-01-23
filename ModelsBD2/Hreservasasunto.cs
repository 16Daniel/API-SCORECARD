using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreservasasunto
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public string Serieasunto { get; set; } = null!;
        public int Numeroasunto { get; set; }
        public int? Idlinea { get; set; }
        public int? Idperiodo { get; set; }
        public int? Idlin { get; set; }
        public int? Idocupante { get; set; }

        public virtual Asunto Asunto { get; set; } = null!;
        public virtual Hreservascab Hreservascab { get; set; } = null!;
    }
}
