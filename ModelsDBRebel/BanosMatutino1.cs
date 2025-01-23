using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class BanosMatutino1
    {
        public int Id { get; set; }
        public int? Branch { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Tipo { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
    }
}
