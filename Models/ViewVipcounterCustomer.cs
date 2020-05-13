using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewVipcounterCustomer
    {
        public string CustomerName { get; set; }
        public int BranchId { get; set; }
        public int Id { get; set; }
        public int CounterId { get; set; }
        public int CustomerId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Discount { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int GoodsNum { get; set; }
    }
}
