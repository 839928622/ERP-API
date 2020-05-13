using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderDeliveryBox
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BoxId { get; set; }
        public string OrderBoxStatus { get; set; }
        public int CarId { get; set; }
        public int CarUserId { get; set; }
        public int StockOutUserId { get; set; }
        public string OrderDeliveryStatus { get; set; }
        public DateTime UpdateTime { get; set; }
        public int OrderDeliveryId { get; set; }
        public int OrderBoxId { get; set; }
    }
}
