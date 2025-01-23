using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hreservascentralitum
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public DateTime? Horadespertador { get; set; }
        public bool Nomolestar { get; set; }
        public bool? Lineatelefono { get; set; }

        public virtual Hreserva Hreserva { get; set; } = null!;
    }
}
