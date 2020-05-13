using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysSiteCss
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string CssFileName { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
