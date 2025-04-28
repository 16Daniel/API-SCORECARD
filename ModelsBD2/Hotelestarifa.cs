using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hotelestarifa
    {
        public int Idhotel { get; set; }
        public int Idtarifahotel { get; set; }
        public int Posicion { get; set; }
        public byte[]? Version { get; set; }
        public bool? Booking { get; set; }

        public virtual Hotele IdhotelNavigation { get; set; } = null!;
        public virtual Tarifashotel IdtarifahotelNavigation { get; set; } = null!;
    }
}
