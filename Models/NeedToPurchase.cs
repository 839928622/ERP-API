using System;

namespace ERP_API.Models
{
    public partial class NeedToPurchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Memo { get; set; }
        public int Status { get; set; }
        public int PrintNum { get; set; }
        public int BranchId { get; set; }
    }
}
