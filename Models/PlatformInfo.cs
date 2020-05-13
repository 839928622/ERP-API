using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PlatformInfo
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int IProjectId { get; set; }
        public string PlatformCode { get; set; }
        public string PlatformName { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
