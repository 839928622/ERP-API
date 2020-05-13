using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsGroupDetail
    {
        public int Id { get; set; }
        public int GoodsGroupId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
