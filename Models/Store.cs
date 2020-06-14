using System;

namespace ERP_API.Models
{
    public partial class Store
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public bool IsDefault { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
