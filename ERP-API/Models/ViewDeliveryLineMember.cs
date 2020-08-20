using System;

namespace ERP_API.Models
{
    public partial class ViewDeliveryLineMember
    {
        public int MemberId { get; set; }
        public int LineId { get; set; }
        public int Distance { get; set; }
        public string Remark { get; set; }
        public DateTime UpdateTime { get; set; }
        public string LineName { get; set; }
        public int BranchId { get; set; }
    }
}
