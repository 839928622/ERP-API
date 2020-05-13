using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsLog
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int Category { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreatorUserId { get; set; }
        public string Remark { get; set; }
        public int Tenant { get; set; }
        public string GoodsName { get; set; }
        public string UserName { get; set; }
        public string Tracking { get; set; }
    }
}
