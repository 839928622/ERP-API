using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class OrderCheckoutLog
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime CheckoutTime { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreatorUserId { get; set; }
        public string Remark { get; set; }
        public int Tenant { get; set; }
    }
}
