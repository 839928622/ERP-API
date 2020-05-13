using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchHelpContent
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int HelpId { get; set; }
        public string Content { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
