using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class VipapplyModify
    {
        public int Id { get; set; }
        public int ApplyId { get; set; }
        public int GoodsId { get; set; }
        public int OldNum { get; set; }
        public int NewNum { get; set; }
        public int OperaterId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Unit { get; set; }
    }
}
