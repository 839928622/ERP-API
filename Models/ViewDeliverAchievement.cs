using System;

namespace ERP_API.Models
{
    public partial class ViewDeliverAchievement
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public DateTime OrderTime { get; set; }
        public string PickUser { get; set; }
        public DateTime PickTime { get; set; }
        public string DeliveryUser { get; set; }
        public DateTime DeliveryFinishTime { get; set; }
        public int? DeliveryDays { get; set; }
        public int BranchId { get; set; }
    }
}
