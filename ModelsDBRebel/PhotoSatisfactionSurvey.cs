using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoSatisfactionSurvey
    {
        public int Id { get; set; }
        public int SatisfactionsurveyId { get; set; }
        public string Photo { get; set; } = null!;
        public int Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual SatisfactionSurvey Satisfactionsurvey { get; set; } = null!;
    }
}
