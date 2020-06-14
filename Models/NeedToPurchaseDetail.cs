using System;

namespace ERP_API.Models
{
    public partial class NeedToPurchaseDetail
    {
        public int Id { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int GoodsId { get; set; }
        public string GoodsMemo { get; set; }
        public int Num { get; set; }
        public int LackNum { get; set; }
        public string PurchaseType { get; set; }
        public string PurchaseMemo { get; set; }
        public string CreditCard { get; set; }
        public bool Emergency { get; set; }
        public int SupplierId { get; set; }
        public int? UserId { get; set; }
        public decimal? InPrice { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsCustomGoods { get; set; }
        public int OrderDetailId { get; set; }
        public string Memo { get; set; }
        public int StoreId { get; set; }
    }
}
