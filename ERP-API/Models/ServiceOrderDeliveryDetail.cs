using System;

namespace ERP_API.Models
{
    public partial class ServiceOrderDeliveryDetail
    {
        public int Id { get; set; }
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
