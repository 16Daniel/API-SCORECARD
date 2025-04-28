using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class FormField
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int TypeFieldId { get; set; }
        public string NameField { get; set; } = null!;
        public string Align { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Task Task { get; set; } = null!;
        public virtual CatTypeField TypeField { get; set; } = null!;
    }
}
