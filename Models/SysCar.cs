using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysCar
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Plate { get; set; }
        public bool? IsEnable { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
