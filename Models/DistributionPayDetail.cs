using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class DistributionPayDetail
    {
        public int Id { get; set; }
        public int PayId { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
