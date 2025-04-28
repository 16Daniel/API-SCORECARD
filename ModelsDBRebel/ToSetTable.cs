using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class ToSetTable
    {
        public ToSetTable()
        {
            PhotoToSetTables = new HashSet<PhotoToSetTable>();
        }

        public int Id { get; set; }
        public int? Branch { get; set; }
        public string CommentSalon { get; set; } = null!;
        public string CommentCocina { get; set; } = null!;
        public string CommentMeet { get; set; } = null!;
        public decimal Cajeros { get; set; }
        public decimal Vendedores { get; set; }
        public decimal Cocineros { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<PhotoToSetTable> PhotoToSetTables { get; set; }
    }
}
