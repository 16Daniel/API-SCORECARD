using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoCompleteProductsInOrder
    {
        public int Id { get; set; }
        public int CompleteProductsInOrderId { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CompleteProductsInOrder CompleteProductsInOrder { get; set; } = null!;
    }
}
