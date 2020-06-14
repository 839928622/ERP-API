using System;

namespace ERP_API.Models
{
    public partial class ViewGroupPay
    {
        public int Id { get; set; }
        public int OrderStatementId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal PayMoney { get; set; }
        public string PayType { get; set; }
        public DateTime PayDate { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public string UserName { get; set; }
        public decimal SumMoney { get; set; }
    }
}
