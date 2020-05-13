using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Ac { get; set; }
        public decimal Amount { get; set; }
        public decimal Point { get; set; }
        public string PurchaseMemo { get; set; }
        public int PickNum { get; set; }
        public bool IsGift { get; set; }
        public string SingleRemark { get; set; }
        public string InternalRemark { get; set; }
        public bool IsTotalPriceModel { get; set; }
        public bool IsCustomGoods { get; set; }
        public bool AntiCounterfeiting { get; set; }
        public int DisplayNum { get; set; }
        public string DisplayUnit { get; set; }
        public decimal DisplayPrice { get; set; }
        public bool IsComment { get; set; }
        public int OldOrderId { get; set; }
        public int RefundNum { get; set; }
        public string GrossProfitPercent { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NoTaxAmount { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal NoTaxPrice { get; set; }
        public decimal DisplayNoTaxPrice { get; set; }
        public decimal Afc { get; set; }
    }
}
