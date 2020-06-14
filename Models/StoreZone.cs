using System;

namespace ERP_API.Models
{
    public partial class StoreZone
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public string Type { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int PrintNum { get; set; }
        public string Name { get; set; }
    }
}
