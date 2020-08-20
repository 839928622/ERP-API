using System;

namespace ERP_API.Models
{
    public partial class OrderDelivery
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CarUserId { get; set; }
        public int StockOutUserId { get; set; }
        public string Status { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Memo { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
