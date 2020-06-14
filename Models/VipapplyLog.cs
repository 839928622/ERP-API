using System;

namespace ERP_API.Models
{
    public partial class VipapplyLog
    {
        public int Id { get; set; }
        public int ApplyId { get; set; }
        public int ApplyUserId { get; set; }
        public int OperatorId { get; set; }
        public string OperateStatus { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
