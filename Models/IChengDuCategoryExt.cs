using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IChengDuCategoryExt
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string Code { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Summoney { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
