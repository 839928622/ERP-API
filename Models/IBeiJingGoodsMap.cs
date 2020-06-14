using System;

namespace ERP_API.Models
{
    public partial class IBeiJingGoodsMap
    {
        public int Id { get; set; }
        public string IBeiJingProductId { get; set; }
        public int DonvvGoodsId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
    }
}
