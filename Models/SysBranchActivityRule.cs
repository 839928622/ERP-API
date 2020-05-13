using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchActivityRule
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public decimal RangeAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public int GiftMaxNum { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
