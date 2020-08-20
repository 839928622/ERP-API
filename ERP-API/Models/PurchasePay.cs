using System;

namespace ERP_API.Models
{
    public partial class PurchasePay
    {
        public int Id { get; set; }
        public int PurchaseStatementId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal PayMoney { get; set; }
        public string PayType { get; set; }
        public DateTime PayDate { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PayAccount { get; set; }
        public int PrepaymentId { get; set; }
    }
}
