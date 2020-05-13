using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsPackageLog
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string Type { get; set; }
        public int OldNum { get; set; }
        public int Num { get; set; }
        public string OldName { get; set; }
        public string Name { get; set; }
        public int IsDefault { get; set; }
        public string OldBarCode { get; set; }
        public string BarCode { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
