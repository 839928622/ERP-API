using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PrintTempletDic
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Tag { get; set; }
        public string Vuale { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
