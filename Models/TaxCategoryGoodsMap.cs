using System;

namespace ERP_API.Models
{
    public partial class TaxCategoryGoodsMap
    {
        public int Id { get; set; }
        public int TaxCategoryId { get; set; }
        public int GoodsId { get; set; }
        public int BranchId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
