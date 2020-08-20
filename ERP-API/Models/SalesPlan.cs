using System;

namespace ERP_API.Models
{
    public partial class SalesPlan
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public int SalesId { get; set; }
        public string SalesName { get; set; }
        public DateTime PlanDate { get; set; }
        public decimal PlanMoney { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
