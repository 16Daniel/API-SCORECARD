using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mappingsidimportacion
    {
        public int Idmap { get; set; }
        public int Posicion { get; set; }
        public string? Fieldname { get; set; }

        public virtual Mappingscab IdmapNavigation { get; set; } = null!;
    }
}
