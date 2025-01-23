using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoCashRegisterShortage
    {
        public int Id { get; set; }
        public int CashRegisterShortageId { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CashRegisterShortage CashRegisterShortage { get; set; } = null!;
        public virtual User CreatedByNavigation { get; set; } = null!;
    }
}
