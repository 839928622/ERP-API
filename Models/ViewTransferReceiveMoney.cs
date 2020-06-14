using System;

namespace ERP_API.Models
{
    public partial class ViewTransferReceiveMoney
    {
        public int Id { get; set; }
        public int TransferStatementId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal ReceiveMoney { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string PayType { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public decimal SumMoney { get; set; }
        public string PayStatus { get; set; }
        public decimal PaidMoney { get; set; }
        public string BranchName { get; set; }
        public string UserName { get; set; }
    }
}
