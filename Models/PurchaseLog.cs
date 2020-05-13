using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PurchaseLog
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public string PurchaseType { get; set; }
        public decimal SumMoney { get; set; }
        public string PurchaseStatus { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Operate { get; set; }
        public bool IsInner { get; set; }
    }
}
