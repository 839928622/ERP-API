using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewMemberDeliveryLine
    {
        public int? BranchId { get; set; }
        public string LineName { get; set; }
        public string RealName { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public int Id { get; set; }
        public int? LineId { get; set; }
    }
}
