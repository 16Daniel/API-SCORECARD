using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemControlreplicacion
    {
        public int Idfront { get; set; }
        public string Terminal { get; set; } = null!;
        public DateTime? Fechaerror { get; set; }
        public DateTime? Fechaact { get; set; }
        public int? Estado { get; set; }
        public int? Transcola { get; set; }
        public string? Errormsg { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
