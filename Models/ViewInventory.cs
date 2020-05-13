using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewInventory
    {
        public int StoreId { get; set; }
        public string StoreZone { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Ac { get; set; }
        public decimal Afc { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public int Id { get; set; }
        public bool IsCustomGoods { get; set; }
        public int OrderDetailId { get; set; }
        public string StoreZoneMemo { get; set; }
        public int GiftNum { get; set; }
    }
}
