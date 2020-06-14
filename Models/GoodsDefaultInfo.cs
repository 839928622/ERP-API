using System;

namespace ERP_API.Models
{
    public partial class GoodsDefaultInfo
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int PurchaseUserId { get; set; }
        public int AddUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime AddTime { get; set; }
        public int BranchId { get; set; }
    }
}
