using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewPurchasePayAudit
    {
        public int PurchaseStatementId { get; set; }
        public decimal ChargeOff { get; set; }
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
        public string Status { get; set; }
        public string Remark { get; set; }
        public string ApproveUser { get; set; }
        public string FinanceData { get; set; }
        public int Id { get; set; }
    }
}
