using System;

namespace ERP_API.Models
{
    public partial class SysBranchCss
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CssId { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
