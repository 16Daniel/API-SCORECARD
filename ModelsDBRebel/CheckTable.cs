using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CheckTable
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int NumTable { get; set; }
        public bool ProductOne { get; set; }
        public string? CommentProductOne { get; set; }
        public bool ProductTwo { get; set; }
        public string? CommentProductTwo { get; set; }
        public bool ProductThree { get; set; }
        public string? CommentProductThree { get; set; }
        public bool ProductFour { get; set; }
        public string? CommentProductFour { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
