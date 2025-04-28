using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class AenaContrato
    {
        public AenaContrato()
        {
            AenaSubfamilia = new HashSet<AenaSubfamilia>();
        }

        public int IdContrato { get; set; }
        public string? DescripcionContrato { get; set; }
        public string? CodigoAena { get; set; }
        public bool? Fijo { get; set; }

        public virtual ICollection<AenaSubfamilia> AenaSubfamilia { get; set; }
    }
}
