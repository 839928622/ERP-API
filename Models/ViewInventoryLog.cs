using System;

namespace ERP_API.Models
{
    public partial class ViewInventoryLog
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int StoreId { get; set; }
        public string Operate { get; set; }
        public int RelationId { get; set; }
        public int OldNum { get; set; }
        public int Num { get; set; }
        public decimal Ac { get; set; }
        public decimal Afc { get; set; }
        public string OldStoreZone { get; set; }
        public string StoreZone { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int NewNum { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public bool IsCustomGoods { get; set; }
    }
}
