using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoValidationGa
    {
        public int Id { get; set; }
        public int ValidationGasId { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ValidationGa ValidationGas { get; set; } = null!;
    }
}
