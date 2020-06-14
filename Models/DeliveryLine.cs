using System;

namespace ERP_API.Models
{
    public partial class DeliveryLine
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string LineName { get; set; }
        public string LineRange { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
