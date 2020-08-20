using System;

namespace ERP_API.Models
{
    public partial class SysPrintSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string OrderHeader { get; set; }
        public string OrderLogoUrl { get; set; }
        public string OrderInstruction { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? PrintFlag { get; set; }
        public bool IsDefault { get; set; }
        public string Title { get; set; }
    }
}
