using System;

namespace ERP_API.Models
{
    public partial class InventoryStock
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int GoodsId { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
    }
}
