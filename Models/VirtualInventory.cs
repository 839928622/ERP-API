﻿using System;

namespace ERP_API.Models
{
    public partial class VirtualInventory
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
