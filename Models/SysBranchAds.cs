using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchAds
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int TypeId { get; set; }
        public string Image1 { get; set; }
        public string Href1 { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
