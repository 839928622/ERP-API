using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class TransferDeliveryBox
    {
        public int Id { get; set; }
        public int TransferDeliveryId { get; set; }
        public int TransferBoxId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
