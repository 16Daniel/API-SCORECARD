using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class SatisfactionSurvey
    {
        public SatisfactionSurvey()
        {
            PhotoSatisfactionSurveys = new HashSet<PhotoSatisfactionSurvey>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public string? TableN { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool QuestionOne { get; set; }
        public bool QuestionTwo { get; set; }
        public bool QuestionThree { get; set; }
        public bool QuestionFour { get; set; }
        public bool QuestionFive { get; set; }
        public bool QuestionSix { get; set; }
        public int Review { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoSatisfactionSurvey> PhotoSatisfactionSurveys { get; set; }
    }
}
