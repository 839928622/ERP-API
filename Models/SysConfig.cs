using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysConfig
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int BranchId { get; set; }
    }
}
