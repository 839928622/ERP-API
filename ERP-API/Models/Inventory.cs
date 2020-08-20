using System;

namespace ERP_API.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string StoreZone { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Ac { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsCustomGoods { get; set; }
        public int OrderDetailId { get; set; }
        public string StoreZoneMemo { get; set; }
        public int GiftNum { get; set; }
        public decimal Afc { get; set; }
    }
}
