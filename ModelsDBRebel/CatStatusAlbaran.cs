using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatStatusAlbaran
    {
        public CatStatusAlbaran()
        {
            Albarans = new HashSet<Albaran>();
        }

        public int Id { get; set; }
        public string Status { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Albaran> Albarans { get; set; }
    }
}
