using System;

namespace ERP_API.Models
{
    public partial class OrderBox
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BoxId { get; set; }
        public int PrintNum { get; set; }
        public DateTime PrintTime { get; set; }
        public string Status { get; set; }
        public string StoreZone { get; set; }
        public DateTime UpdateTime { get; set; }
        public int PackageNumber { get; set; }
    }
}
