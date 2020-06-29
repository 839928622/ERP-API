using System;

namespace ERP_API.Models
{
    public partial class GoodsDefaultInfo : BaseEntity
    {
        public int GoodsId { get; set; }
        public int PurchaseUserId { get; set; }
        public int AddUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime AddTime { get; set; }
    }
}
