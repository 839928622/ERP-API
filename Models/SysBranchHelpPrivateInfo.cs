using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchHelpPrivateInfo
    {
        public int Id { get; set; }
        public int HelpId { get; set; }
        public int BranchId { get; set; }
        public string Alias { get; set; }
        public int Sort { get; set; }
        public bool IsDisable { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
