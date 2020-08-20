using System;

namespace ERP_API.Models
{
    public partial class DefaultStore : BaseEntity
    {
        
        public string Name { get; set; }
        public string Place { get; set; }
        public string OrderType { get; set; }
        public DateTime UpdateTime { get; set; }
        public int StoreId { get; set; }
    }
}
