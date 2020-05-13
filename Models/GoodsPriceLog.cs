using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsPriceLog
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int GoodsId { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
