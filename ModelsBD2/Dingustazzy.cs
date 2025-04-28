using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Dingustazzy
    {
        public int Idhotel { get; set; }
        public bool Descarga { get; set; }
        public bool Subida { get; set; }
        public string Syncrosvcurl { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Hotelcode { get; set; } = null!;
        public int? Tiporeserva { get; set; }
        public bool Enproduccion { get; set; }
        public bool Mapear { get; set; }
        public bool Maparticulos { get; set; }
        public bool Mapagencias { get; set; }
        public string? Fieldarticulos { get; set; }
        public string? Fieldagencias { get; set; }

        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
