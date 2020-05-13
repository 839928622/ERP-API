using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsComment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int MemberId { get; set; }
        public int Level { get; set; }
        public string Label { get; set; }
        public string Content { get; set; }
        public DateTime? OrderTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
