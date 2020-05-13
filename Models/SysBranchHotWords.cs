using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchHotWords
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string HotWords { get; set; }
        public int Sort { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Href { get; set; }
    }
}
