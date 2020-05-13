using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool OrderConfirmGift { get; set; }
        public bool OrderConfirmPriceLessInPrice { get; set; }
        public int PurchaseCollectDefaultPurchaser { get; set; }
        public bool AutoAuditing { get; set; }
        public bool HideSaleNum { get; set; }
        public bool HidePurchaseZero { get; set; }
        public bool ReturnOrderInStoreForCheck { get; set; }
        public int AccountPeriodLimitOrder { get; set; }
        public bool IsCustomMessageSignature { get; set; }
        public bool GoodsCategory { get; set; }
        public bool GoodsDetailDisplayInventory { get; set; }
        public bool GoodsListRandom { get; set; }
        public bool Canvass { get; set; }
        public bool AddThirdPartyId { get; set; }
        public bool IsShowGrossProfit { get; set; }
        public bool IsAccountVialid { get; set; }
        public bool GroupCheckedAllOrder { get; set; }
        public bool IsCustomerDetails { get; set; }
        public bool? BranchSite { get; set; }
        public bool SingleStroe { get; set; }
        public bool? CustomerNeedApprove { get; set; }
        public bool IsRepeatGoodsSn { get; set; }
        public bool IsHideGoodsEvaluate { get; set; }
        public bool IsThird { get; set; }
        public int CustomerManageId { get; set; }
        public bool? LimitOrderForNoStock { get; set; }
        public bool? IsDefaultStore { get; set; }
        public int? LimitWebOrderForNoVirtualStock { get; set; }
        public bool? FinanceAudit { get; set; }
        public bool? OnlyMallOrder { get; set; }
        public string BranchIdOfHideMoney { get; set; }
        public bool? InPriceHigherThanPrice { get; set; }
        public bool? OrderRequiredMemo { get; set; }
        public bool? ModifyGoodsUnit { get; set; }
        public bool? IsShowInvalidPurchaser { get; set; }
        public bool? IsShowGoodsSaleCount { get; set; }
        public bool? OrderConfirmReturnDirectDelivery { get; set; }
        public bool? PurchaseCollectByStore { get; set; }
        public bool? StoreOrderUsePrice { get; set; }
        public decimal? OrderDefaultTaxRate { get; set; }
        public decimal? PurchaseDefaultTaxRate { get; set; }
        public bool SpecifySupplier { get; set; }
        public bool ShowVirtualSales { get; set; }
        public bool? OrderToDistribution { get; set; }
        public bool StoreOrderSpecifySalesman { get; set; }
        public bool StoreOrderSpicifyInventory { get; set; }
        public bool PurchaseByOwin { get; set; }
        public bool ExportByAdmin { get; set; }
    }
}
