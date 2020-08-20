using System;

namespace ERP_API.Models
{
    public partial class VipcounterCustomer
    {
        public int Id { get; set; }
        public int CounterId { get; set; }
        public int CustomerId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Discount { get; set; }
        public int UserId { get; set; }
    }
}
