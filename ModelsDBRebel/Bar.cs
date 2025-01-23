using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Bar
    {
        public Bar()
        {
            PhotoBars = new HashSet<PhotoBar>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool Sink { get; set; }
        public string? CommentSink { get; set; }
        public bool Mixer { get; set; }
        public string? CommentMixer { get; set; }
        public bool Refrigerator { get; set; }
        public string? CommentRefrigerator { get; set; }
        public bool ElectricalConnections { get; set; }
        public string? CommentElectricalConnections { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoBar> PhotoBars { get; set; }
    }
}
