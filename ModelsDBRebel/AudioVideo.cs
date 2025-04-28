using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class AudioVideo
    {
        public AudioVideo()
        {
            PhotoAudioVideos = new HashSet<PhotoAudioVideo>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool TvWorksProperly { get; set; }
        public string CommentTvWorksProperly { get; set; } = null!;
        public bool SpeakersWorkProperly { get; set; }
        public string CommentSpeakersWorkProperly { get; set; } = null!;
        public bool TerraceTvWorksProperly { get; set; }
        public string CommentTerraceTvWorksProperly { get; set; } = null!;
        public bool TerraceSpeakersWorkProperly { get; set; }
        public string CommentTerraceSpeakersWorkProperly { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoAudioVideo> PhotoAudioVideos { get; set; }
    }
}
