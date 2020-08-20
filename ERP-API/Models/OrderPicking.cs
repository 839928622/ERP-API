using System;

namespace ERP_API.Models
{
    public partial class OrderPicking
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PickingUserId { get; set; }
        public int DistributeUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
