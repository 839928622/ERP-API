using System;

namespace ERP_API.Models
{
    public partial class IGoodsMap
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl { get; set; }
        public int SkuId { get; set; }
        public string ProductNameEc { get; set; }
        public string ProductUrlEc { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
