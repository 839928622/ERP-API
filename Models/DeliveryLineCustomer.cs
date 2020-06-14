using System;

namespace ERP_API.Models
{
    public partial class DeliveryLineCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int LineId { get; set; }
        public int Distance { get; set; }
        public string Remark { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
