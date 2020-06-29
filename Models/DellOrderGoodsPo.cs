using System;

namespace ERP_API.Models
{
    public partial class DellOrderGoodsPo : BaseEntity
    {
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
        public string Po { get; set; }
        public int? GoodsId { get; set; }
        public string GoodsName { get; set; }
        public int? GoodsNum { get; set; }
        public decimal? GoodsPrice { get; set; }
        public string Status { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
