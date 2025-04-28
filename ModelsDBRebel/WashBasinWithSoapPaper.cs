using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class WashBasinWithSoapPaper
    {
        public WashBasinWithSoapPaper()
        {
            PhotoWashBasinWithSoapPapers = new HashSet<PhotoWashBasinWithSoapPaper>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool IsThereSoapPaper { get; set; }
        public bool IsThereDryer { get; set; }
        public string CommentSoapPaper { get; set; } = null!;
        public string CommentDryer { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoWashBasinWithSoapPaper> PhotoWashBasinWithSoapPapers { get; set; }
    }
}
