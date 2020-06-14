using System;

namespace ERP_API.Models
{
    public partial class ViewTransferStatement
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal ChargeOff { get; set; }
        public string BranchName { get; set; }
        public string UserName { get; set; }
    }
}
