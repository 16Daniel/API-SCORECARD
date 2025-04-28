using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class ValidationGa
    {
        public ValidationGa()
        {
            PhotoValidationGas = new HashSet<PhotoValidationGa>();
        }

        public int Id { get; set; }
        public int? Branch { get; set; }
        public decimal Amount { get; set; }
        public string? Comment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<PhotoValidationGa> PhotoValidationGas { get; set; }
    }
}
