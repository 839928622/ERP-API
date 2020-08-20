using System;

namespace ERP_API.Models
{
    public partial class OrderDistribution
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BranchId { get; set; }
        public int PbranchId { get; set; }
        public int OriginalBranchId { get; set; }
        public double ParentReceiveRate { get; set; }
        public decimal SumMoney { get; set; }
        public int UserId { get; set; }
        public DateTime AddTime { get; set; }
        public bool IsDelete { get; set; }
        public int PayStatus { get; set; }
        public decimal PayChargeOff { get; set; }
        public int InvoiceStatus { get; set; }
        public decimal InvoiceChargeOff { get; set; }
    }
}
