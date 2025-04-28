using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoToSetTable
    {
        public int Id { get; set; }
        public int? ToSetTableId { get; set; }
        public string? Photo { get; set; }
        public int Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ToSetTable? ToSetTable { get; set; }
    }
}
