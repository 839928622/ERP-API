using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class Gift
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int Point { get; set; }
        public int MaxNum { get; set; }
        public int IsValid { get; set; }
        public string GiftName { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
    }
}
