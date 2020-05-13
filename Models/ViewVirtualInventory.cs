using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewVirtualInventory
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public int TypeId { get; set; }
        public string UserName { get; set; }
    }
}
