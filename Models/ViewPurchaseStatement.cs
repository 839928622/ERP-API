using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewPurchaseStatement
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string SupplierName { get; set; }
        public string LinkMan { get; set; }
        public string Mobile { get; set; }
        public string ShortName { get; set; }
        public string UserName { get; set; }
        public string Expr1 { get; set; }
        public decimal ChargeOff { get; set; }
    }
}
