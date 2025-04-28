using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoSalon
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public string Photo { get; set; } = null!;
        public int Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Salon Salon { get; set; } = null!;
    }
}
