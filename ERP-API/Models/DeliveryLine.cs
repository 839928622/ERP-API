using System;

namespace ERP_API.Models
{
    public partial class DeliveryLine : BaseEntity
    {
      
        public string LineName { get; set; }
        public string LineRange { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
