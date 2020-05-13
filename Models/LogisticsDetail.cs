using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class LogisticsDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Content { get; set; }
        public DateTime OperateTime { get; set; }
        public string Operator { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
