using System;

namespace ERP_API.Models
{
    public partial class SysGroupBranch
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int BranchId { get; set; }
        public string JoinType { get; set; }
        public bool IsGroupAccount { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
