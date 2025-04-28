using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Albaran
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public DateTime AlbaranDate { get; set; }
        public TimeSpan AlbaranTime { get; set; }
        public string AlbaranDescription { get; set; } = null!;
        public string NumSerie { get; set; } = null!;
        public int NumAlbaran { get; set; }
        public string N { get; set; } = null!;
        public int StatusId { get; set; }
        public TimeSpan TimeArrive { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatStatusAlbaran Status { get; set; } = null!;
    }
}
