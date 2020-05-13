using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SalesStoreMap
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? SalesNo { get; set; }
        public string SalesName { get; set; }
        public int? StoreId { get; set; }
        public string StoreName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsEnable { get; set; }
    }
}
