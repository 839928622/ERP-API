using System;

namespace ERP_API.Models
{
    public partial class IBeiJingGoodsMap : BaseEntity
    {
        public string IBeiJingProductId { get; set; }
        public int DonvvGoodsId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
