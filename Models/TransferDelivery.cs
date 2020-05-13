using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class TransferDelivery
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CarUserId { get; set; }
        public int StockOutUserId { get; set; }
        public string Status { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Memo { get; set; }
    }
}
