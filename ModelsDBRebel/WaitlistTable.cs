using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class WaitlistTable
    {
        public WaitlistTable()
        {
            PhotoWaitlistTables = new HashSet<PhotoWaitlistTable>();
        }

        public int Id { get; set; }
        public int Branch { get; set; }
        public bool WaitlistTables { get; set; }
        public int? HowManyTables { get; set; }
        public int? NumberPeople { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Comment { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<PhotoWaitlistTable> PhotoWaitlistTables { get; set; }
    }
}
