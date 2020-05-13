using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SourceGoods
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SourceId { get; set; }
        public string Url { get; set; }
        public string SourceSku { get; set; }
        public string SourceMainSku { get; set; }
        public string SpecVals { get; set; }
        public string SourceCategory { get; set; }
        public string SourceBrand { get; set; }
        public decimal SourcePrice { get; set; }
        public int TargetParentId { get; set; }
        public int TargetGoodsId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
