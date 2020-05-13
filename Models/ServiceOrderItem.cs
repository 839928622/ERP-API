using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ServiceOrderItem
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int? Item { get; set; }
        public string ItemName { get; set; }
        public int Num { get; set; }
        public string Remark { get; set; }
    }
}
