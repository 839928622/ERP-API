using System;

namespace ERP_API.Models
{
    public partial class OrderDeliveryBox
    {
        public int Id { get; set; }
        public int OrderDeliveryId { get; set; }
        public int OrderBoxId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
