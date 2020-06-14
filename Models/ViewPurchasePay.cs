using System;

namespace ERP_API.Models
{
    public partial class ViewPurchasePay
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
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string TelPhone { get; set; }
        public string LinkMan { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string PayAccount { get; set; }
        public int? PayAccountId { get; set; }
    }
}
