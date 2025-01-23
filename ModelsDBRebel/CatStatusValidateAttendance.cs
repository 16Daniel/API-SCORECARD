using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatStatusValidateAttendance
    {
        public CatStatusValidateAttendance()
        {
            ValidateAttendances = new HashSet<ValidateAttendance>();
        }

        public int Id { get; set; }
        public string Status { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<ValidateAttendance> ValidateAttendances { get; set; }
    }
}
