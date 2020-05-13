using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysDept
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
