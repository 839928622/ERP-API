using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchActivityGift
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int ActivityRuleId { get; set; }
        public int GiftNum { get; set; }
        public int MaxGiftNum { get; set; }
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public string Unit { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
