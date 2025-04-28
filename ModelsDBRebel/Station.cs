using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Station
    {
        public Station()
        {
            PhotoStations = new HashSet<PhotoStation>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool Chips { get; set; }
        public bool Clean { get; set; }
        public bool CompleteAssembly { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoStation> PhotoStations { get; set; }
    }
}
