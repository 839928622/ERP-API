using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PurchasePayDetail
    {
        public int Id { get; set; }
        public int PayId { get; set; }
        public int PurchaseId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal InPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
