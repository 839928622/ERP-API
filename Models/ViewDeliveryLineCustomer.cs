using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewDeliveryLineCustomer
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string LineName { get; set; }
        public string LineRange { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telphone { get; set; }
    }
}
