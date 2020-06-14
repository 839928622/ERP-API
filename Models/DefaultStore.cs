using System;

namespace ERP_API.Models
{
    public partial class DefaultStore
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string OrderType { get; set; }
        public DateTime UpdateTime { get; set; }
        public int StoreId { get; set; }
    }
}
