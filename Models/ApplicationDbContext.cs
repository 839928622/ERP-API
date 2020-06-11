using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ERP_API.EntityConfigurations;
using ERP_API.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP_API.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        private readonly string _branchIdString;
        private readonly int _branchId;
        public bool CheckAccrossBranchIdOprations { get; set; } = true;
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _branchIdString =  httpContextAccessor.HttpContext.User.FindFirst(CustomizedClaims.BranchId).Value;
            _branchId =  Convert.ToInt32(_branchIdString);
        }

        public virtual DbSet<AttachedFil> AttachedFil { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<CanvassAgreement> CanvassAgreement { get; set; }
        public virtual DbSet<CatagoryParams> CatagoryParams { get; set; }
        public virtual DbSet<CrawlerRequest> CrawlerRequest { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerBalanceLog> CustomerBalanceLog { get; set; }
        public virtual DbSet<CustomerInvoiceInfo> CustomerInvoiceInfo { get; set; }
        public virtual DbSet<CustomerLog> CustomerLog { get; set; }
        public virtual DbSet<CustomerPreReceiveMoney> CustomerPreReceiveMoney { get; set; }
        public virtual DbSet<CustomerSetting> CustomerSetting { get; set; }
        public virtual DbSet<DefaultStore> DefaultStore { get; set; }
        public virtual DbSet<DeliveryLine> DeliveryLine { get; set; }
        public virtual DbSet<DeliveryLineCustomer> DeliveryLineCustomer { get; set; }
        public virtual DbSet<DeliveryLineMember> DeliveryLineMember { get; set; }
        public virtual DbSet<DellOrderGoodsPo> DellOrderGoodsPo { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<DeptTemp> DeptTemp { get; set; }
        public virtual DbSet<DistributionCustomerInvoice> DistributionCustomerInvoice { get; set; }
        public virtual DbSet<DistributionCustomerInvoiceDetail> DistributionCustomerInvoiceDetail { get; set; }
        public virtual DbSet<DistributionCustomerReceiveMoney> DistributionCustomerReceiveMoney { get; set; }
        public virtual DbSet<DistributionCustomerReceiveMoneyDetail> DistributionCustomerReceiveMoneyDetail { get; set; }
        public virtual DbSet<DistributionInvoice> DistributionInvoice { get; set; }
        public virtual DbSet<DistributionInvoiceDetail> DistributionInvoiceDetail { get; set; }
        public virtual DbSet<DistributionOperation> DistributionOperation { get; set; }
        public virtual DbSet<DistributionOrderState> DistributionOrderState { get; set; }
        public virtual DbSet<DistributionPay> DistributionPay { get; set; }
        public virtual DbSet<DistributionPayDetail> DistributionPayDetail { get; set; }
        public virtual DbSet<DistributionReceiveInvoice> DistributionReceiveInvoice { get; set; }
        public virtual DbSet<DistributionReceiveInvoiceDetail> DistributionReceiveInvoiceDetail { get; set; }
        public virtual DbSet<DistributionReceiveMoney> DistributionReceiveMoney { get; set; }
        public virtual DbSet<DistributionReceiveMoneyDetail> DistributionReceiveMoneyDetail { get; set; }
        public virtual DbSet<Dostatement> Dostatement { get; set; }
        public virtual DbSet<DostatementDetail> DostatementDetail { get; set; }
        public virtual DbSet<Dpstatement> Dpstatement { get; set; }
        public virtual DbSet<DpstatementDetail> DpstatementDetail { get; set; }
        public virtual DbSet<EmailInvoiceSetting> EmailInvoiceSetting { get; set; }
        public virtual DbSet<FinanceAudit> FinanceAudit { get; set; }
        public virtual DbSet<FinanceRecord> FinanceRecord { get; set; }
        public virtual DbSet<FinanceSubject> FinanceSubject { get; set; }
        public virtual DbSet<Franchisee> Franchisee { get; set; }
        public virtual DbSet<Gift> Gift { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsCaptcha> GoodsCaptcha { get; set; }
        public virtual DbSet<GoodsCategory> GoodsCategory { get; set; }
        public virtual DbSet<GoodsComment> GoodsComment { get; set; }
        public virtual DbSet<GoodsDefaultInfo> GoodsDefaultInfo { get; set; }
        public virtual DbSet<GoodsExtensions> GoodsExtensions { get; set; }
        public virtual DbSet<GoodsGroupDetail> GoodsGroupDetail { get; set; }
        public virtual DbSet<GoodsLog> GoodsLog { get; set; }
        public virtual DbSet<GoodsModel> GoodsModel { get; set; }
        public virtual DbSet<GoodsModelValue> GoodsModelValue { get; set; }
        public virtual DbSet<GoodsPackage> GoodsPackage { get; set; }
        public virtual DbSet<GoodsPackageLog> GoodsPackageLog { get; set; }
        public virtual DbSet<GoodsParamValue> GoodsParamValue { get; set; }
        public virtual DbSet<GoodsPhoto> GoodsPhoto { get; set; }
        public virtual DbSet<GoodsPriceLog> GoodsPriceLog { get; set; }
        public virtual DbSet<GoodsType> GoodsType { get; set; }
        public virtual DbSet<GoodsTypeParam> GoodsTypeParam { get; set; }
        public virtual DbSet<GoodsTypeParamGroup> GoodsTypeParamGroup { get; set; }
        public virtual DbSet<GoodsTypeParamOption> GoodsTypeParamOption { get; set; }
        public virtual DbSet<GoodsTypePrivateInfo> GoodsTypePrivateInfo { get; set; }
        public virtual DbSet<GoodsTypeUpdate> GoodsTypeUpdate { get; set; }
        public virtual DbSet<GroupOrderStatement> GroupOrderStatement { get; set; }
        public virtual DbSet<GroupOrderStatementDetail> GroupOrderStatementDetail { get; set; }
        public virtual DbSet<GroupPay> GroupPay { get; set; }
        public virtual DbSet<IAnalysis> IAnalysis { get; set; }
        public virtual DbSet<IBeiJingGoods> IBeiJingGoods { get; set; }
        public virtual DbSet<IBeiJingGoodsMap> IBeiJingGoodsMap { get; set; }
        public virtual DbSet<IBeiJingProductParam> IBeiJingProductParam { get; set; }
        public virtual DbSet<IBeiJingZhengCaiCityList> IBeiJingZhengCaiCityList { get; set; }
        public virtual DbSet<ICategory> ICategory { get; set; }
        public virtual DbSet<IChengDuCategoryExt> IChengDuCategoryExt { get; set; }
        public virtual DbSet<IChengDuCategoryParam> IChengDuCategoryParam { get; set; }
        public virtual DbSet<IChengDuParamValue> IChengDuParamValue { get; set; }
        public virtual DbSet<IEfficientGoods> IEfficientGoods { get; set; }
        public virtual DbSet<IEgoods> IEgoods { get; set; }
        public virtual DbSet<IErrLog> IErrLog { get; set; }
        public virtual DbSet<IGoods> IGoods { get; set; }
        public virtual DbSet<IGoodsLog> IGoodsLog { get; set; }
        public virtual DbSet<IGoodsMap> IGoodsMap { get; set; }
        public virtual DbSet<IGoodsOperateLog> IGoodsOperateLog { get; set; }
        public virtual DbSet<IGoodsPart> IGoodsPart { get; set; }
        public virtual DbSet<IMessage> IMessage { get; set; }
        public virtual DbSet<IOrderDetail> IOrderDetail { get; set; }
        public virtual DbSet<IOrderExtension> IOrderExtension { get; set; }
        public virtual DbSet<IOrders> IOrders { get; set; }
        public virtual DbSet<IPlat> IPlat { get; set; }
        public virtual DbSet<IProduct> IProduct { get; set; }
        public virtual DbSet<IProductsForZgly> IProductsForZgly { get; set; }
        public virtual DbSet<IProductsMapForZgly> IProductsMapForZgly { get; set; }
        public virtual DbSet<IProject> IProject { get; set; }
        public virtual DbSet<IProjectExtention> IProjectExtention { get; set; }
        public virtual DbSet<IProvider> IProvider { get; set; }
        public virtual DbSet<Icontract> Icontract { get; set; }
        public virtual DbSet<IcontractMy> IcontractMy { get; set; }
        public virtual DbSet<IntroductionInvestment> IntroductionInvestment { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryLog> InventoryLog { get; set; }
        public virtual DbSet<InventoryModifyAc> InventoryModifyAc { get; set; }
        public virtual DbSet<InventoryStock> InventoryStock { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLog> InvoiceLog { get; set; }
        public virtual DbSet<InvoiceRequire> InvoiceRequire { get; set; }
        public virtual DbSet<InvoiceRequireDetail> InvoiceRequireDetail { get; set; }
        public virtual DbSet<IorderContract> IorderContract { get; set; }
        public virtual DbSet<LoginedIdentity> LoginedIdentity { get; set; }
        public virtual DbSet<Logistics> Logistics { get; set; }
        public virtual DbSet<LogisticsCompany> LogisticsCompany { get; set; }
        public virtual DbSet<LogisticsDetail> LogisticsDetail { get; set; }
        public virtual DbSet<LogisticsInfomation> LogisticsInfomation { get; set; }
        public virtual DbSet<LogisticsSubscribeLog> LogisticsSubscribeLog { get; set; }
        public virtual DbSet<LogisticsSupported> LogisticsSupported { get; set; }
        public virtual DbSet<MajorParamsDetail> MajorParamsDetail { get; set; }
        public virtual DbSet<MallFloatAd> MallFloatAd { get; set; }
        public virtual DbSet<MallSideBar> MallSideBar { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberAddress> MemberAddress { get; set; }
        public virtual DbSet<MemberAddressTemp> MemberAddressTemp { get; set; }
        public virtual DbSet<MemberApplyDept> MemberApplyDept { get; set; }
        public virtual DbSet<MemberAuth> MemberAuth { get; set; }
        public virtual DbSet<MemberCart> MemberCart { get; set; }
        public virtual DbSet<MemberFav> MemberFav { get; set; }
        public virtual DbSet<MemberInvoiceInfo> MemberInvoiceInfo { get; set; }
        public virtual DbSet<MemberLog> MemberLog { get; set; }
        public virtual DbSet<MemberOrderDept> MemberOrderDept { get; set; }
        public virtual DbSet<MemberPoint> MemberPoint { get; set; }
        public virtual DbSet<MemberRole> MemberRole { get; set; }
        public virtual DbSet<MemberTemp> MemberTemp { get; set; }
        public virtual DbSet<ModifyAc> ModifyAc { get; set; }
        public virtual DbSet<NeedToPurchase> NeedToPurchase { get; set; }
        public virtual DbSet<NeedToPurchaseDetail> NeedToPurchaseDetail { get; set; }
        public virtual DbSet<NeedToPurchaseOrder> NeedToPurchaseOrder { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<NotifyMsg> NotifyMsg { get; set; }
        public virtual DbSet<NotifySetting> NotifySetting { get; set; }
        public virtual DbSet<NotifySmsSign> NotifySmsSign { get; set; }
        public virtual DbSet<NotifyTemplet> NotifyTemplet { get; set; }
        public virtual DbSet<OrderAfterSale> OrderAfterSale { get; set; }
        public virtual DbSet<OrderAfterSaleFlow> OrderAfterSaleFlow { get; set; }
        public virtual DbSet<OrderAfterSalePhoto> OrderAfterSalePhoto { get; set; }
        public virtual DbSet<OrderArchive> OrderArchive { get; set; }
        public virtual DbSet<OrderBox> OrderBox { get; set; }
        public virtual DbSet<OrderCheckoutLog> OrderCheckoutLog { get; set; }
        public virtual DbSet<OrderDelivery> OrderDelivery { get; set; }
        public virtual DbSet<OrderDeliveryBox> OrderDeliveryBox { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderDistribution> OrderDistribution { get; set; }
        public virtual DbSet<OrderDistributionDetail> OrderDistributionDetail { get; set; }
        public virtual DbSet<OrderGoodsComments> OrderGoodsComments { get; set; }
        public virtual DbSet<OrderInvoiceInfo> OrderInvoiceInfo { get; set; }
        public virtual DbSet<OrderLog> OrderLog { get; set; }
        public virtual DbSet<OrderModify> OrderModify { get; set; }
        public virtual DbSet<OrderModifyAc> OrderModifyAc { get; set; }
        public virtual DbSet<OrderPicking> OrderPicking { get; set; }
        public virtual DbSet<OrderPickingLog> OrderPickingLog { get; set; }
        public virtual DbSet<OrderReceiveMoney> OrderReceiveMoney { get; set; }
        public virtual DbSet<OrderReceiveMoneyDetail> OrderReceiveMoneyDetail { get; set; }
        public virtual DbSet<OrderStatement> OrderStatement { get; set; }
        public virtual DbSet<OrderStatementCrossInvoice> OrderStatementCrossInvoice { get; set; }
        public virtual DbSet<OrderStatementDetail> OrderStatementDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ParamGather> ParamGather { get; set; }
        public virtual DbSet<PayLog> PayLog { get; set; }
        public virtual DbSet<PlatformInfo> PlatformInfo { get; set; }
        public virtual DbSet<PreGoodsPhoto> PreGoodsPhoto { get; set; }
        public virtual DbSet<PreInvoice> PreInvoice { get; set; }
        public virtual DbSet<PrintTempletDic> PrintTempletDic { get; set; }
        public virtual DbSet<ProGoodsType> ProGoodsType { get; set; }
        public virtual DbSet<ProductGoodsType> ProductGoodsType { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public virtual DbSet<PurchaseLog> PurchaseLog { get; set; }
        public virtual DbSet<PurchaseMerge> PurchaseMerge { get; set; }
        public virtual DbSet<PurchaseModify> PurchaseModify { get; set; }
        public virtual DbSet<PurchasePay> PurchasePay { get; set; }
        public virtual DbSet<PurchasePayDetail> PurchasePayDetail { get; set; }
        public virtual DbSet<PurchaseQuote> PurchaseQuote { get; set; }
        public virtual DbSet<PurchaseQuoteDetail> PurchaseQuoteDetail { get; set; }
        public virtual DbSet<PurchaseStatement> PurchaseStatement { get; set; }
        public virtual DbSet<PurchaseStatementDetail> PurchaseStatementDetail { get; set; }
        public virtual DbSet<Quotation> Quotation { get; set; }
        public virtual DbSet<RegisterProtocol> RegisterProtocol { get; set; }
        public virtual DbSet<SalesPlan> SalesPlan { get; set; }
        public virtual DbSet<SalesStoreMap> SalesStoreMap { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrder { get; set; }
        public virtual DbSet<ServiceOrderDelivery> ServiceOrderDelivery { get; set; }
        public virtual DbSet<ServiceOrderDeliveryDetail> ServiceOrderDeliveryDetail { get; set; }
        public virtual DbSet<ServiceOrderDetail> ServiceOrderDetail { get; set; }
        public virtual DbSet<ServiceOrderItem> ServiceOrderItem { get; set; }
        public virtual DbSet<ServiceOrderLog> ServiceOrderLog { get; set; }
        public virtual DbSet<ServiceOrderStaff> ServiceOrderStaff { get; set; }
        public virtual DbSet<SiChuanLog> SiChuanLog { get; set; }
        public virtual DbSet<SourceGoods> SourceGoods { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreZone> StoreZone { get; set; }
        public virtual DbSet<StrategyGrossProfit> StrategyGrossProfit { get; set; }
        public virtual DbSet<StrategyItem> StrategyItem { get; set; }
        public virtual DbSet<StrategyOrigin> StrategyOrigin { get; set; }
        public virtual DbSet<StrategyRange> StrategyRange { get; set; }
        public virtual DbSet<StrategyRule> StrategyRule { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierContacts> SupplierContacts { get; set; }
        public virtual DbSet<SupplierDepartment> SupplierDepartment { get; set; }
        public virtual DbSet<SupplierInvoice> SupplierInvoice { get; set; }
        public virtual DbSet<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        public virtual DbSet<SupplierPrepayment> SupplierPrepayment { get; set; }
        public virtual DbSet<SupplierSettleAccounts> SupplierSettleAccounts { get; set; }
        public virtual DbSet<SurveysFeedBack> SurveysFeedBack { get; set; }
        public virtual DbSet<SysAgent> SysAgent { get; set; }
        public virtual DbSet<SysAgentUsers> SysAgentUsers { get; set; }
        public virtual DbSet<SysApprove> SysApprove { get; set; }
        public virtual DbSet<SysAuthorize> SysAuthorize { get; set; }
        public virtual DbSet<SysBranch> SysBranch { get; set; }
        public virtual DbSet<SysBranchActivity> SysBranchActivity { get; set; }
        public virtual DbSet<SysBranchActivityContent> SysBranchActivityContent { get; set; }
        public virtual DbSet<SysBranchActivityGift> SysBranchActivityGift { get; set; }
        public virtual DbSet<SysBranchActivityRange> SysBranchActivityRange { get; set; }
        public virtual DbSet<SysBranchActivityRule> SysBranchActivityRule { get; set; }
        public virtual DbSet<SysBranchAds> SysBranchAds { get; set; }
        public virtual DbSet<SysBranchArea> SysBranchArea { get; set; }
        public virtual DbSet<SysBranchAreaDetail> SysBranchAreaDetail { get; set; }
        public virtual DbSet<SysBranchAreas> SysBranchAreas { get; set; }
        public virtual DbSet<SysBranchAuth> SysBranchAuth { get; set; }
        public virtual DbSet<SysBranchBankInfo> SysBranchBankInfo { get; set; }
        public virtual DbSet<SysBranchCss> SysBranchCss { get; set; }
        public virtual DbSet<SysBranchEmailSetting> SysBranchEmailSetting { get; set; }
        public virtual DbSet<SysBranchErpsetting> SysBranchErpsetting { get; set; }
        public virtual DbSet<SysBranchFloor> SysBranchFloor { get; set; }
        public virtual DbSet<SysBranchFloorBrandingWall> SysBranchFloorBrandingWall { get; set; }
        public virtual DbSet<SysBranchFloorBrandingWallPhotos> SysBranchFloorBrandingWallPhotos { get; set; }
        public virtual DbSet<SysBranchFloorDisplayType> SysBranchFloorDisplayType { get; set; }
        public virtual DbSet<SysBranchGoodsType> SysBranchGoodsType { get; set; }
        public virtual DbSet<SysBranchHelp> SysBranchHelp { get; set; }
        public virtual DbSet<SysBranchHelpContent> SysBranchHelpContent { get; set; }
        public virtual DbSet<SysBranchHelpGroup> SysBranchHelpGroup { get; set; }
        public virtual DbSet<SysBranchHelpGroupPrivateInfo> SysBranchHelpGroupPrivateInfo { get; set; }
        public virtual DbSet<SysBranchHelpPrivateInfo> SysBranchHelpPrivateInfo { get; set; }
        public virtual DbSet<SysBranchHotWords> SysBranchHotWords { get; set; }
        public virtual DbSet<SysBranchPay> SysBranchPay { get; set; }
        public virtual DbSet<SysBranchPayment> SysBranchPayment { get; set; }
        public virtual DbSet<SysBranchSeo> SysBranchSeo { get; set; }
        public virtual DbSet<SysBranchServicePromise> SysBranchServicePromise { get; set; }
        public virtual DbSet<SysBranchServicePromiseDetail> SysBranchServicePromiseDetail { get; set; }
        public virtual DbSet<SysBranchSetting> SysBranchSetting { get; set; }
        public virtual DbSet<SysBranchSiteFooter> SysBranchSiteFooter { get; set; }
        public virtual DbSet<SysBranchSiteSetting> SysBranchSiteSetting { get; set; }
        public virtual DbSet<SysBranchSiteSolution> SysBranchSiteSolution { get; set; }
        public virtual DbSet<SysBranchTheme> SysBranchTheme { get; set; }
        public virtual DbSet<SysBranchThemeArea> SysBranchThemeArea { get; set; }
        public virtual DbSet<SysBranchThemeAreaGoodsTab> SysBranchThemeAreaGoodsTab { get; set; }
        public virtual DbSet<SysBranchThemeAreaPhoto> SysBranchThemeAreaPhoto { get; set; }
        public virtual DbSet<SysBranchThirdParty> SysBranchThirdParty { get; set; }
        public virtual DbSet<SysBranchTopMenu> SysBranchTopMenu { get; set; }
        public virtual DbSet<SysCanvassAgreement> SysCanvassAgreement { get; set; }
        public virtual DbSet<SysCar> SysCar { get; set; }
        public virtual DbSet<SysCarLog> SysCarLog { get; set; }
        public virtual DbSet<SysCarUser> SysCarUser { get; set; }
        public virtual DbSet<SysCity> SysCity { get; set; }
        public virtual DbSet<SysConfig> SysConfig { get; set; }
        public virtual DbSet<SysDept> SysDept { get; set; }
        public virtual DbSet<SysDictionary> SysDictionary { get; set; }
        public virtual DbSet<SysDictionaryType> SysDictionaryType { get; set; }
        public virtual DbSet<SysDistribution> SysDistribution { get; set; }
        public virtual DbSet<SysDistributionGroup> SysDistributionGroup { get; set; }
        public virtual DbSet<SysErrorLog> SysErrorLog { get; set; }
        public virtual DbSet<SysGroup> SysGroup { get; set; }
        public virtual DbSet<SysGroupBranch> SysGroupBranch { get; set; }
        public virtual DbSet<SysGroupLoginSetting> SysGroupLoginSetting { get; set; }
        public virtual DbSet<SysMapiServer> SysMapiServer { get; set; }
        public virtual DbSet<SysPermission> SysPermission { get; set; }
        public virtual DbSet<SysPermissionGroup> SysPermissionGroup { get; set; }
        public virtual DbSet<SysPrice> SysPrice { get; set; }
        public virtual DbSet<SysPrintSetting> SysPrintSetting { get; set; }
        public virtual DbSet<SysPrintTemplate> SysPrintTemplate { get; set; }
        public virtual DbSet<SysPrintValidate> SysPrintValidate { get; set; }
        public virtual DbSet<SysRenew> SysRenew { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysRolePermission> SysRolePermission { get; set; }
        public virtual DbSet<SysSiteCss> SysSiteCss { get; set; }
        public virtual DbSet<SysSms> SysSms { get; set; }
        public virtual DbSet<SysUrlLog> SysUrlLog { get; set; }
        public virtual DbSet<SysUserRole> SysUserRole { get; set; }
        public virtual DbSet<SysUsers> SysUsers { get; set; }
        public virtual DbSet<SystemManager> SystemManager { get; set; }
        public virtual DbSet<TaxCategory> TaxCategory { get; set; }
        public virtual DbSet<TaxCategoryGoodsMap> TaxCategoryGoodsMap { get; set; }
        public virtual DbSet<Temp> Temp { get; set; }
        public virtual DbSet<ThirdCategory> ThirdCategory { get; set; }
        public virtual DbSet<ThirdPartyGoodsCategoryMatch> ThirdPartyGoodsCategoryMatch { get; set; }
        public virtual DbSet<ThirdPartyGoodsMatch> ThirdPartyGoodsMatch { get; set; }
        public virtual DbSet<ThirdPartyLogin> ThirdPartyLogin { get; set; }
        public virtual DbSet<ThirdProduct> ThirdProduct { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<TransferArchive> TransferArchive { get; set; }
        public virtual DbSet<TransferBox> TransferBox { get; set; }
        public virtual DbSet<TransferDelivery> TransferDelivery { get; set; }
        public virtual DbSet<TransferDeliveryBox> TransferDeliveryBox { get; set; }
        public virtual DbSet<TransferDetail> TransferDetail { get; set; }
        public virtual DbSet<TransferLog> TransferLog { get; set; }
        public virtual DbSet<TransferPicking> TransferPicking { get; set; }
        public virtual DbSet<TransferPickingLog> TransferPickingLog { get; set; }
        public virtual DbSet<TransferReceiveMoney> TransferReceiveMoney { get; set; }
        public virtual DbSet<TransferStatement> TransferStatement { get; set; }
        public virtual DbSet<TransferStatementDetail> TransferStatementDetail { get; set; }
        public virtual DbSet<VDeadLockProcess> VDeadLockProcess { get; set; }
        public virtual DbSet<ViewCustomer> ViewCustomer { get; set; }
        public virtual DbSet<ViewCustomerCounterDetail> ViewCustomerCounterDetail { get; set; }
        public virtual DbSet<ViewCustomerLog> ViewCustomerLog { get; set; }
        public virtual DbSet<ViewCustomerPreReceiveMoney> ViewCustomerPreReceiveMoney { get; set; }
        public virtual DbSet<ViewDeliverAchievement> ViewDeliverAchievement { get; set; }
        public virtual DbSet<ViewDeliveryLineCustomer> ViewDeliveryLineCustomer { get; set; }
        public virtual DbSet<ViewDeliveryLineMember> ViewDeliveryLineMember { get; set; }
        public virtual DbSet<ViewDistributionCustomerInvoice> ViewDistributionCustomerInvoice { get; set; }
        public virtual DbSet<ViewDistributionCustomerInvoiceDetail> ViewDistributionCustomerInvoiceDetail { get; set; }
        public virtual DbSet<ViewDistributionCustomerReceiveMoney> ViewDistributionCustomerReceiveMoney { get; set; }
        public virtual DbSet<ViewDistributionCustomerReceiveMoneyDetail> ViewDistributionCustomerReceiveMoneyDetail { get; set; }
        public virtual DbSet<ViewDistributionInvoice> ViewDistributionInvoice { get; set; }
        public virtual DbSet<ViewDistributionInvoiceDetail> ViewDistributionInvoiceDetail { get; set; }
        public virtual DbSet<ViewDistributionPay> ViewDistributionPay { get; set; }
        public virtual DbSet<ViewDistributionPayDetail> ViewDistributionPayDetail { get; set; }
        public virtual DbSet<ViewDistributionReceiveInvoice> ViewDistributionReceiveInvoice { get; set; }
        public virtual DbSet<ViewDistributionReceiveInvoiceDetail> ViewDistributionReceiveInvoiceDetail { get; set; }
        public virtual DbSet<ViewDistributionReceiveMoney> ViewDistributionReceiveMoney { get; set; }
        public virtual DbSet<ViewDistributionReceiveMoneyDetail> ViewDistributionReceiveMoneyDetail { get; set; }
        public virtual DbSet<ViewDostatement> ViewDostatement { get; set; }
        public virtual DbSet<ViewDpstatement> ViewDpstatement { get; set; }
        public virtual DbSet<ViewGoods> ViewGoods { get; set; }
        public virtual DbSet<ViewGoodsDefaultInfo> ViewGoodsDefaultInfo { get; set; }
        public virtual DbSet<ViewGoodsModelValue> ViewGoodsModelValue { get; set; }
        public virtual DbSet<ViewGoodsPackage> ViewGoodsPackage { get; set; }
        public virtual DbSet<ViewGoodsParamValue> ViewGoodsParamValue { get; set; }
        public virtual DbSet<ViewGoodsPhoto> ViewGoodsPhoto { get; set; }
        public virtual DbSet<ViewGoodsTypeParam> ViewGoodsTypeParam { get; set; }
        public virtual DbSet<ViewGroupOrderStatement> ViewGroupOrderStatement { get; set; }
        public virtual DbSet<ViewGroupPay> ViewGroupPay { get; set; }
        public virtual DbSet<ViewIbeiJingGoodsMap> ViewIbeiJingGoodsMap { get; set; }
        public virtual DbSet<ViewIcategory> ViewIcategory { get; set; }
        public virtual DbSet<ViewIgoods> ViewIgoods { get; set; }
        public virtual DbSet<ViewInventory> ViewInventory { get; set; }
        public virtual DbSet<ViewInventoryLog> ViewInventoryLog { get; set; }
        public virtual DbSet<ViewInventoryModifyAc> ViewInventoryModifyAc { get; set; }
        public virtual DbSet<ViewInvoice> ViewInvoice { get; set; }
        public virtual DbSet<ViewInvoiceAudit> ViewInvoiceAudit { get; set; }
        public virtual DbSet<ViewInvoiceLog> ViewInvoiceLog { get; set; }
        public virtual DbSet<ViewInvoiceRequire> ViewInvoiceRequire { get; set; }
        public virtual DbSet<ViewInvoiceRequireDetail> ViewInvoiceRequireDetail { get; set; }
        public virtual DbSet<ViewIorderContract> ViewIorderContract { get; set; }
        public virtual DbSet<ViewIprojectPlat> ViewIprojectPlat { get; set; }
        public virtual DbSet<ViewLogisticsCompany> ViewLogisticsCompany { get; set; }
        public virtual DbSet<ViewMember> ViewMember { get; set; }
        public virtual DbSet<ViewMemberAddress> ViewMemberAddress { get; set; }
        public virtual DbSet<ViewMemberCart> ViewMemberCart { get; set; }
        public virtual DbSet<ViewMemberDeliveryLine> ViewMemberDeliveryLine { get; set; }
        public virtual DbSet<ViewMemberOrders> ViewMemberOrders { get; set; }
        public virtual DbSet<ViewModifyAc> ViewModifyAc { get; set; }
        public virtual DbSet<ViewNeedToPurchaseDetail> ViewNeedToPurchaseDetail { get; set; }
        public virtual DbSet<ViewNews> ViewNews { get; set; }
        public virtual DbSet<ViewOrderAfterSale> ViewOrderAfterSale { get; set; }
        public virtual DbSet<ViewOrderDeliveryBox> ViewOrderDeliveryBox { get; set; }
        public virtual DbSet<ViewOrderDetail> ViewOrderDetail { get; set; }
        public virtual DbSet<ViewOrderDetailGoods> ViewOrderDetailGoods { get; set; }
        public virtual DbSet<ViewOrderDistribution> ViewOrderDistribution { get; set; }
        public virtual DbSet<ViewOrderDistributionDetail> ViewOrderDistributionDetail { get; set; }
        public virtual DbSet<ViewOrderGoodsComments> ViewOrderGoodsComments { get; set; }
        public virtual DbSet<ViewOrderModify> ViewOrderModify { get; set; }
        public virtual DbSet<ViewOrderModifyAc> ViewOrderModifyAc { get; set; }
        public virtual DbSet<ViewOrderPicking> ViewOrderPicking { get; set; }
        public virtual DbSet<ViewOrderReceiveMoney> ViewOrderReceiveMoney { get; set; }
        public virtual DbSet<ViewOrderReceiveMoneyDetail> ViewOrderReceiveMoneyDetail { get; set; }
        public virtual DbSet<ViewOrderStatement> ViewOrderStatement { get; set; }
        public virtual DbSet<ViewOrders> ViewOrders { get; set; }
        public virtual DbSet<ViewOrdersYangCaiLog> ViewOrdersYangCaiLog { get; set; }
        public virtual DbSet<ViewOrmaudit> ViewOrmaudit { get; set; }
        public virtual DbSet<ViewPickOrderDetail> ViewPickOrderDetail { get; set; }
        public virtual DbSet<ViewPickPurchaseDetail> ViewPickPurchaseDetail { get; set; }
        public virtual DbSet<ViewProductInfo> ViewProductInfo { get; set; }
        public virtual DbSet<ViewPurchase> ViewPurchase { get; set; }
        public virtual DbSet<ViewPurchaseDetail> ViewPurchaseDetail { get; set; }
        public virtual DbSet<ViewPurchaseLog> ViewPurchaseLog { get; set; }
        public virtual DbSet<ViewPurchaseModify> ViewPurchaseModify { get; set; }
        public virtual DbSet<ViewPurchasePay> ViewPurchasePay { get; set; }
        public virtual DbSet<ViewPurchasePayAudit> ViewPurchasePayAudit { get; set; }
        public virtual DbSet<ViewPurchasePayDetail> ViewPurchasePayDetail { get; set; }
        public virtual DbSet<ViewPurchaseQuoteDetail> ViewPurchaseQuoteDetail { get; set; }
        public virtual DbSet<ViewPurchaseStatement> ViewPurchaseStatement { get; set; }
        public virtual DbSet<ViewPurchaseStatementDetail> ViewPurchaseStatementDetail { get; set; }
        public virtual DbSet<ViewPurchaseStatementGoodsDetail> ViewPurchaseStatementGoodsDetail { get; set; }
        public virtual DbSet<ViewQuotationOrder> ViewQuotationOrder { get; set; }
        public virtual DbSet<ViewSourceGoods> ViewSourceGoods { get; set; }
        public virtual DbSet<ViewSupplierDetail> ViewSupplierDetail { get; set; }
        public virtual DbSet<ViewSupplierInvoice> ViewSupplierInvoice { get; set; }
        public virtual DbSet<ViewSupplierInvoiceDetails> ViewSupplierInvoiceDetails { get; set; }
        public virtual DbSet<ViewSupplierOrder> ViewSupplierOrder { get; set; }
        public virtual DbSet<ViewSupplierPrepayment> ViewSupplierPrepayment { get; set; }
        public virtual DbSet<ViewSupplierReceiveInvoice> ViewSupplierReceiveInvoice { get; set; }
        public virtual DbSet<ViewSupplierSettleAccounts> ViewSupplierSettleAccounts { get; set; }
        public virtual DbSet<ViewSysBranchCss> ViewSysBranchCss { get; set; }
        public virtual DbSet<ViewSysBranchGroup> ViewSysBranchGroup { get; set; }
        public virtual DbSet<ViewSysDistribution> ViewSysDistribution { get; set; }
        public virtual DbSet<ViewSysPermission> ViewSysPermission { get; set; }
        public virtual DbSet<ViewSysRolePermission> ViewSysRolePermission { get; set; }
        public virtual DbSet<ViewSysUsers> ViewSysUsers { get; set; }
        public virtual DbSet<ViewTaxCategory> ViewTaxCategory { get; set; }
        public virtual DbSet<ViewTransfer> ViewTransfer { get; set; }
        public virtual DbSet<ViewTransferDeliveryBox> ViewTransferDeliveryBox { get; set; }
        public virtual DbSet<ViewTransferDetail> ViewTransferDetail { get; set; }
        public virtual DbSet<ViewTransferPicking> ViewTransferPicking { get; set; }
        public virtual DbSet<ViewTransferReceiveMoney> ViewTransferReceiveMoney { get; set; }
        public virtual DbSet<ViewTransferStatement> ViewTransferStatement { get; set; }
        public virtual DbSet<ViewUserPermission> ViewUserPermission { get; set; }
        public virtual DbSet<ViewUserRole> ViewUserRole { get; set; }
        public virtual DbSet<ViewVipapply> ViewVipapply { get; set; }
        public virtual DbSet<ViewVipapplyDetail> ViewVipapplyDetail { get; set; }
        public virtual DbSet<ViewVipcounterCustomer> ViewVipcounterCustomer { get; set; }
        public virtual DbSet<ViewVipcounterDetail> ViewVipcounterDetail { get; set; }
        public virtual DbSet<ViewVirtualInventory> ViewVirtualInventory { get; set; }
        public virtual DbSet<Vipapply> Vipapply { get; set; }
        public virtual DbSet<VipapplyDetail> VipapplyDetail { get; set; }
        public virtual DbSet<VipapplyInvoiceInfo> VipapplyInvoiceInfo { get; set; }
        public virtual DbSet<VipapplyLog> VipapplyLog { get; set; }
        public virtual DbSet<VipapplyModify> VipapplyModify { get; set; }
        public virtual DbSet<Vipcounter> Vipcounter { get; set; }
        public virtual DbSet<VipcounterCustomer> VipcounterCustomer { get; set; }
        public virtual DbSet<VipcounterDetail> VipcounterDetail { get; set; }
        public virtual DbSet<VirtualInventory> VirtualInventory { get; set; }
        public virtual DbSet<YangCaiOrderLog> YangCaiOrderLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (string.IsNullOrEmpty(_branchIdString) && System.Environment.GetEnvironmentVariable($"{_branchIdString}") != null)
                {

                    optionsBuilder.UseSqlServer(System.Environment.GetEnvironmentVariable($"{_branchIdString}") ??
                                                throw new InvalidOperationException
                                                ("Can not read ConnecttingString from EnvironmentVariable"));
                }
                else
                {
                    optionsBuilder.UseSqlServer(System.Environment.GetEnvironmentVariable("ERPDB") ?? 
                                                throw new InvalidOperationException
                                                    ("Can not read ConnecttingString from EnvironmentVariable"));
                }
            }
            this.Database.Migrate(); // not sure if this block of code work correctly
        }
        public void SetGlobalQuery<T>(ModelBuilder builder) where T: BaseEntity
        {
            builder.Entity<T>().HasKey(e => e.Id);
            builder.Entity<T>().HasQueryFilter(e => e.BranchId == _branchId);//全表过滤
        }
        public override int SaveChanges()
        {
            if (CheckAccrossBranchIdOprations)
            {
                CheckAccrossBranchOpration();
            }
            return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            if (CheckAccrossBranchIdOprations)
            {
                CheckAccrossBranchOpration();
            }
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            if (CheckAccrossBranchIdOprations)
            {
                CheckAccrossBranchOpration();
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            if (CheckAccrossBranchIdOprations)
            {
                CheckAccrossBranchOpration();
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

      

        private void CheckAccrossBranchOpration()
        {
            var ids = (from e in ChangeTracker.Entries()
                    where e.Entity is BaseEntity
                    select ((BaseEntity) e.Entity).BranchId)
                .Distinct().ToList();
            if (ids.Count == 0)
            {
                return;
            }

            if (ids.Count > 1)
            {
                throw new CrossBranchOperationException($"EF检测到跨Branch操作，当前Branch:{_branchId},跨越Branch为：[{string.Join(',',ids)}]");
            }

            if (ids.First() != _branchId)
            {
                throw new CrossBranchOperationException($"EF检测到跨Branch操作，当前Branch:{_branchId},跨越Branch为：[{string.Join(',', ids)}]");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AttachedFilConfiguration());
            //modelBuilder.ApplyConfiguration(new BrandConfiguration());
            //modelBuilder.ApplyConfiguration(new CanvassAgreementConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryParamsConfiguration());
            //modelBuilder.ApplyConfiguration(new CrawlerRequestConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerBalanceLogConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerInvoiceInfoConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerLogConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerPreReceiveMoneyConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerSettingConfiguration());
            //modelBuilder.ApplyConfiguration(new DefaultStoreConfiguration());
            //modelBuilder.ApplyConfiguration(new DeliveryLineConfiguration());
            //modelBuilder.ApplyConfiguration(new DeliveryLineCustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new DeliveryLineMemberConfiguration());
            //modelBuilder.ApplyConfiguration(new DellOrderGoodsPoConfiguration());
            //modelBuilder.ApplyConfiguration(new DeptConfiguration());
            //modelBuilder.ApplyConfiguration(new DeptTempConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionCustomerInvoiceConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionCustomerInvoiceDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionCustomerReceiveMoneyConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionCustomerReceiveMoneyDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionInvoiceConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionInvoiceDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionOrderStateConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionPayConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionPayDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionReceiveInvoiceConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionReceiveInvoiceDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionReceiveMoneyConfiguration());
            //modelBuilder.ApplyConfiguration(new DistributionReceiveMoneyDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DostatementConfiguration());
            //modelBuilder.ApplyConfiguration(new DostatementDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new DpstatementConfiguration());
            //modelBuilder.ApplyConfiguration(new DpstatementDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new EmailInvoiceSettingConfiguration());
            //modelBuilder.ApplyConfiguration(new FinanceAuditConfiguration());
            //modelBuilder.ApplyConfiguration(new FinanceRecordConfiguration());
            //modelBuilder.ApplyConfiguration(new FinanceSubjectConfiguration());
            //modelBuilder.ApplyConfiguration(new FranchiseeConfiguration());
            //modelBuilder.ApplyConfiguration(new GiftConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsCaptchaConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsCommentConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsDefaultInfoConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsGroupDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsLogConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsModelConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsModelValueConfiguration());
            //modelBuilder.ApplyConfiguration(new GoodsPackageConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            

            

            modelBuilder.Entity<IBeiJingProductParam>(entity =>
            {
                entity.ToTable("I_BeiJingProductParam");

                entity.Property(e => e.IParamName)
                    .HasColumnName("I_ParamName")
                    .HasMaxLength(255);

                entity.Property(e => e.IParamValue)
                    .HasColumnName("I_ParamValue")
                    .HasColumnType("text");

                entity.Property(e => e.IProductId)
                    .HasColumnName("I_ProductId")
                    .HasMaxLength(255);

                entity.Property(e => e.TlspPk)
                    .HasColumnName("TLSP_PK")
                    .HasMaxLength(255);

                entity.Property(e => e.TppvPk)
                    .HasColumnName("TPPV_PK")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<IBeiJingZhengCaiCityList>(entity =>
            {
                entity.ToTable("I_BeiJingZhengCaiCityList");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Memo).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Parent).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ICategory>(entity =>
            {
                entity.ToTable("I_Category");

                entity.Property(e => e.Discount).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Discount2).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Discount3).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Discount4).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ICategory1)
                    .IsRequired()
                    .HasColumnName("I_Category")
                    .HasMaxLength(100);

                entity.Property(e => e.IPlatId).HasColumnName("I_PlatId");

                entity.Property(e => e.ITypeCode)
                    .IsRequired()
                    .HasColumnName("I_TypeCode")
                    .HasMaxLength(100);

                entity.Property(e => e.ITypeName)
                    .IsRequired()
                    .HasColumnName("I_TypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IChengDuCategoryExt>(entity =>
            {
                entity.ToTable("I_ChengDuCategoryExt");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Summoney).HasColumnType("money");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IChengDuCategoryParam>(entity =>
            {
                entity.ToTable("I_ChengDuCategoryParam");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.Vals).HasColumnType("text");
            });

            modelBuilder.Entity<IChengDuParamValue>(entity =>
            {
                entity.ToTable("I_ChengDuParamValue");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<IEfficientGoods>(entity =>
            {
                entity.ToTable("I_EfficientGoods");

                entity.Property(e => e.AddAt).HasColumnType("datetime");

                entity.Property(e => e.AddBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EfficientGoodsCardNum)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EfficientGoodsCardOrgan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EfficientGoodsImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IprojectId).HasColumnName("IProjectId");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IEgoods>(entity =>
            {
                entity.ToTable("I_EGoods");

                entity.HasComment("商品环保标志");

                entity.Property(e => e.CertDate).HasColumnType("datetime");

                entity.Property(e => e.CertNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IErrLog>(entity =>
            {
                entity.ToTable("I_ErrLog");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.JsonStr)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IGoods>(entity =>
            {
                entity.ToTable("I_Goods");

                entity.HasIndex(e => new { e.GoodsId, e.Unit, e.IProjectId })
                    .HasName("IX_I_Goods")
                    .IsUnique();

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                entity.Property(e => e.MarketPrice).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IGoodsLog>(entity =>
            {
                entity.ToTable("I_GoodsLog");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                entity.Property(e => e.MarketPrice).HasColumnType("money");

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IGoodsMap>(entity =>
            {
                entity.ToTable("I_GoodsMap");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductNameEc)
                    .IsRequired()
                    .HasColumnName("ProductNameEC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductUrl)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductUrlEc)
                    .IsRequired()
                    .HasColumnName("ProductUrlEC")
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IGoodsOperateLog>(entity =>
            {
                entity.ToTable("I_GoodsOperateLog");

                entity.Property(e => e.DtCreate)
                    .HasColumnName("dtCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdate)
                    .HasColumnName("dtUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDel).HasComment("是否删除");

                entity.Property(e => e.OperateType).HasComment(@"1，新增商品；
2，修改商品信息；
3，删除商品；
4，商品上下架状态变更；
5，商品价格变更；
6，商品库存变更；
7，商品配件、服务变更；
8，商品图片变更
");
            });

            modelBuilder.Entity<IGoodsPart>(entity =>
            {
                entity.ToTable("I_GoodsPart");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("配件名称");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasComment("售价");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IMessage>(entity =>
            {
                entity.ToTable("I_Message");

                entity.Property(e => e.IprojectId).HasColumnName("IProjectId");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.Result).HasColumnType("text");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IOrderDetail>(entity =>
            {
                entity.ToTable("I_OrderDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.IOrderId)
                    .IsRequired()
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IOrderExtension>(entity =>
            {
                entity.ToTable("I_OrderExtension");

                entity.Property(e => e.AttrName).HasMaxLength(500);

                entity.Property(e => e.AttrVal)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IOrders>(entity =>
            {
                entity.ToTable("I_Orders");

                entity.Property(e => e.ICustomer)
                    .HasColumnName("I_Customer")
                    .HasMaxLength(50);

                entity.Property(e => e.IOrderId)
                    .IsRequired()
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100);

                entity.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.SumMoney).HasColumnType("money");
            });

            modelBuilder.Entity<IPlat>(entity =>
            {
                entity.ToTable("I_Plat");

                entity.Property(e => e.IProviderId).HasColumnName("I_ProviderId");

                entity.Property(e => e.IsPostData).HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IProduct>(entity =>
            {
                entity.ToTable("I_Product");

                entity.Property(e => e.AppKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AppSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IProductsForZgly>(entity =>
            {
                entity.ToTable("I_ProductsForZGLY");

                entity.Property(e => e.IproductName)
                    .HasColumnName("IProductName")
                    .HasMaxLength(500);

                entity.Property(e => e.Isku)
                    .HasColumnName("ISku")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IProductsMapForZgly>(entity =>
            {
                entity.ToTable("I_ProductsMapForZGLY");

                entity.Property(e => e.DonvvSku).HasDefaultValueSql("((0))");

                entity.Property(e => e.IproductSku)
                    .HasColumnName("IProductSku")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IProject>(entity =>
            {
                entity.ToTable("I_Project");

                entity.Property(e => e.AccessToken).HasMaxLength(100);

                entity.Property(e => e.AppKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AppSecret)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.IPlatId).HasColumnName("I_PlatId");

                entity.Property(e => e.PrivateKey)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IProjectExtention>(entity =>
            {
                entity.ToTable("I_ProjectExtention");

                entity.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                entity.Property(e => e.PropName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PropValue)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<IProvider>(entity =>
            {
                entity.ToTable("I_Provider");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Icontract>(entity =>
            {
                entity.ToTable("IContract");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.CompanyNum).HasMaxLength(100);

                entity.Property(e => e.ConNum).HasMaxLength(50);

                entity.Property(e => e.ContractName).HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sign).HasColumnType("text");

                entity.Property(e => e.Signature).HasColumnType("text");

                entity.Property(e => e.Tel).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IcontractMy>(entity =>
            {
                entity.ToTable("IContractMY");

                entity.Property(e => e.DtSignTime)
                    .HasColumnName("dtSignTime")
                    .HasColumnType("datetime")
                    .HasComment("签章时间");

                entity.Property(e => e.DtSubmitTime)
                    .HasColumnName("dtSubmitTime")
                    .HasColumnType("datetime")
                    .HasComment("提交时间");

                entity.Property(e => e.FielUrl)
                    .HasColumnName("fielUrl")
                    .HasMaxLength(255)
                    .HasComment("pdf所在路径");

                entity.Property(e => e.FileByte)
                    .IsRequired()
                    .HasColumnName("fileByte")
                    .HasColumnType("text")
                    .HasComment("未签章合同文件流");

                entity.Property(e => e.FileByted)
                    .HasColumnName("fileByted")
                    .HasColumnType("text")
                    .HasComment("已签章合同文件流");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("fileName")
                    .HasMaxLength(50);

                entity.Property(e => e.IprojectId).HasColumnName("IProjectId");

                entity.Property(e => e.IsSigned).HasComment("是否签章 0：否；1：是");

                entity.Property(e => e.OrderId).HasColumnName("orderId");
            });

            modelBuilder.Entity<IntroductionInvestment>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasIndex(e => new { e.GoodsId, e.StoreId, e.StoreZone, e.IsCustomGoods, e.OrderDetailId })
                    .HasName("IX_Inventory")
                    .IsUnique();

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Afc)
                    .HasColumnName("AFC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StoreZoneMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InventoryLog>(entity =>
            {
                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("money");

                entity.Property(e => e.Afc)
                    .HasColumnName("AFC")
                    .HasColumnType("money");

                entity.Property(e => e.Num).HasComment("本次操作数量，可为负数，比如拣货就是 负数，入库就是正数");

                entity.Property(e => e.OldNum).HasComment("操作前的数量");

                entity.Property(e => e.OldStoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作类型");

                entity.Property(e => e.RelationId).HasComment("相关Id");

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventoryModifyAc>(entity =>
            {
                entity.ToTable("InventoryModifyAC");

                entity.Property(e => e.ModifyAcid).HasColumnName("ModifyACId");

                entity.Property(e => e.NewAc)
                    .HasColumnName("NewAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldAc)
                    .HasColumnName("OldAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StoreZoneMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InventoryStock>(entity =>
            {
                entity.HasIndex(e => new { e.GoodsId, e.StoreId })
                    .HasName("IX_InventoryStock");

                entity.Property(e => e.MaxStock).HasComment("最大库存，库存上限");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.MinStock).HasComment("最小库存，安全库存");

                entity.Property(e => e.StoreId).HasComment("仓库号，如果为0，表示共有商品");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDetailUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdfUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlatInvoiceRequestNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InvoiceLog>(entity =>
            {
                entity.Property(e => e.CancelDetailUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CancelOrderNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelPdfUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CancelPlatInvoiceRequestNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceCreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDeleteTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDetailUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdfUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlatInvoiceRequestNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatementIds)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceRequire>(entity =>
            {
                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasComment("预留字段：收票人");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InvoiceRequireDetail>(entity =>
            {
                entity.Property(e => e.Id).HasComment("唯一标示ID");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceRequireId).HasComment("开票申请表ID");

                entity.Property(e => e.OrderDetailId).HasComment("订单明细Id");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("money");
            });

            modelBuilder.Entity<IorderContract>(entity =>
            {
                entity.ToTable("IOrderContract");

                entity.Property(e => e.ContractNum)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveUser).HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginedIdentity>(entity =>
            {
                entity.Property(e => e.BuyerCookie)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PostUrl).HasColumnType("text");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Logistics>(entity =>
            {
                entity.Property(e => e.AddAt).HasColumnType("datetime");

                entity.Property(e => e.LogisticName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogisticsCompany>(entity =>
            {
                entity.Property(e => e.IsDefault).HasComment("快递，物流，国际");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LogisticsDetail>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogisticsInfomation>(entity =>
            {
                entity.Property(e => e.FromAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FromTelphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticsInfo)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToTelphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LogisticsSubscribeLog>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LogisticsSupported>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LogisticsCompany)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Memo).HasMaxLength(1000);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MajorParamsDetail>(entity =>
            {
                entity.Property(e => e.ParamsName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamsValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MallFloatAd>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImgPath).HasMaxLength(200);

                entity.Property(e => e.ImgUrl).HasMaxLength(200);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MallSideBar>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HoverName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmLevel).HasComment("用户的审核级别");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("邮箱");

                entity.Property(e => e.HeadPortraitUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("即时通讯Id");

                entity.Property(e => e.IsAdmin).HasComment("是否是公司管理员");

                entity.Property(e => e.IsCheckEmail).HasComment("邮件是否验证");

                entity.Property(e => e.IsCheckMobile).HasComment("手机是否验证");

                entity.Property(e => e.IsDelete)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否有效");

                entity.Property(e => e.IsMainContact).HasComment("是否主要联系人");

                entity.Property(e => e.IsOrderAuthority).HasComment("是否有下单权限");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Point).HasComment("积分");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegisterMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('平台开通')")
                    .HasComment("注册方式");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VipcounterLevel)
                    .HasColumnName("VIPCounterLevel")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MemberAddress>(entity =>
            {
                entity.HasIndex(e => e.MemberId)
                    .HasName("IX_MemberAddress");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Area).HasMaxLength(20);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(20);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberAddressTemp>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Area).HasMaxLength(20);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(20);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberApplyDept>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("部门编号");

                entity.Property(e => e.CustomerId).HasComment("客户Id");

                entity.Property(e => e.DeptId).HasComment("此联系人能审核的部门Id");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("部门名称");

                entity.Property(e => e.MemberId).HasComment("联系人Id");

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("父部门编号");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<MemberAuth>(entity =>
            {
                entity.Property(e => e.AccessToken)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RereshToken)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StrustNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemberCart>(entity =>
            {
                entity.HasIndex(e => new { e.MemberId, e.GoodsId, e.Multiples, e.DisplayUnit })
                    .HasName("IX_MemberCart")
                    .IsUnique();

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemberFav>(entity =>
            {
                entity.HasIndex(e => new { e.GoodsId, e.MemberId })
                    .HasName("IX_MemberFav");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemberInvoiceInfo>(entity =>
            {
                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("电子发票邮箱");

                entity.Property(e => e.InvoiceAddress)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("地址");

                entity.Property(e => e.InvoiceBank)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("开户行");

                entity.Property(e => e.InvoiceBankAccount)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("开户行账号");

                entity.Property(e => e.InvoiceCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票类别（纸质、电子）");

                entity.Property(e => e.InvoiceContent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票内容");

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("发票备注");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("发票抬头");

                entity.Property(e => e.InvoicePhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("注册手机");

                entity.Property(e => e.InvoiceReceivePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceTaxNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("税号");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票类型");

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<MemberLog>(entity =>
            {
                entity.Property(e => e.BranchId).HasComment("懂微租户唯一标识");

                entity.Property(e => e.CustomerId).HasComment("客户Id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasComment("联系人Id");

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("联系人名称");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .HasComment("备注");

                entity.Property(e => e.Operate).HasComment("操作，枚举");

                entity.Property(e => e.Tracking).HasComment("联系人关联信息");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<MemberOrderDept>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("部门编号");

                entity.Property(e => e.CustomerId).HasComment("客户Id");

                entity.Property(e => e.DeptId).HasComment("此联系人能下单的部门Id");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("部门名称");

                entity.Property(e => e.MemberId).HasComment("联系人Id");

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("父部门编号");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<MemberPoint>(entity =>
            {
                entity.HasIndex(e => e.MemberId)
                    .HasName("IX_MemberPoint");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.Income).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Spend).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemberRole>(entity =>
            {
                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemberTemp>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDelete)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegisterMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('平台开通')");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VipcounterLevel)
                    .HasColumnName("VIPCounterLevel")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ModifyAc>(entity =>
            {
                entity.ToTable("ModifyAC");

                entity.Property(e => e.Memo).HasMaxLength(1000);

                entity.Property(e => e.ModifyInventoryAc).HasColumnName("ModifyInventoryAC");

                entity.Property(e => e.ModifyOrderDetailAc).HasColumnName("ModifyOrderDetailAC");

                entity.Property(e => e.NewAc)
                    .HasColumnName("NewAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NewInPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldAc)
                    .HasColumnName("OldAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldInPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<NeedToPurchase>(entity =>
            {
                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<NeedToPurchaseDetail>(entity =>
            {
                entity.Property(e => e.CreditCard)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsMemo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.InPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'‘’')");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PublishDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotifyMsg>(entity =>
            {
                entity.ToTable("Notify_Msg");

                entity.HasComment("系统消息");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasComment("内容");

                entity.Property(e => e.CreationTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatorUserId).HasComment("创建用户");

                entity.Property(e => e.DeleterUserId).HasComment("删除用户");

                entity.Property(e => e.DeletionTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.Extend1)
                    .HasMaxLength(200)
                    .HasComment("扩展属性");

                entity.Property(e => e.Extend2).HasComment("扩展值");

                entity.Property(e => e.IsDeleted).HasComment("是否删除");

                entity.Property(e => e.Item).HasComment("消息分类    邮件/短信/系统消息/用户消息");

                entity.Property(e => e.LastModificationTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.LastModifierUserId).HasComment("修改用户");

                entity.Property(e => e.ReceiveId).HasComment("接受者Id");

                entity.Property(e => e.RelationId).HasComment("关联值");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.SendId).HasComment("发送者Id");

                entity.Property(e => e.Status).HasComment("未发送/发送中/发送成功/发送失败");

                entity.Property(e => e.TempletId).HasComment("模板Id");

                entity.Property(e => e.TempletValue)
                    .HasColumnType("text")
                    .HasComment("模板值");

                entity.Property(e => e.Tenant).HasComment("租户");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasComment("标题");

                entity.Property(e => e.Type).HasComment("消息类型");
            });

            modelBuilder.Entity<NotifySetting>(entity =>
            {
                entity.ToTable("Notify_Setting");

                entity.Property(e => e.AppKey).HasMaxLength(200);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.EmailName).HasMaxLength(200);

                entity.Property(e => e.EmailNickName).HasMaxLength(200);

                entity.Property(e => e.EmailPsw).HasMaxLength(200);

                entity.Property(e => e.EmailSmtp).HasMaxLength(200);

                entity.Property(e => e.Extend1).HasMaxLength(200);

                entity.Property(e => e.Extend2).HasMaxLength(200);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(200);
            });

            modelBuilder.Entity<NotifySmsSign>(entity =>
            {
                entity.ToTable("Notify_SmsSign");

                entity.HasComment("短信签名");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.CreationTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatorUserId).HasComment("创建用户");

                entity.Property(e => e.DeleterUserId).HasComment("删除用户");

                entity.Property(e => e.DeletionTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("显示名称");

                entity.Property(e => e.Extend1)
                    .HasMaxLength(50)
                    .HasComment("扩展字段1");

                entity.Property(e => e.Extend2)
                    .HasMaxLength(50)
                    .HasComment("扩展字段2");

                entity.Property(e => e.IsDeleted).HasComment("是否删除");

                entity.Property(e => e.IsEnabled).HasComment("是否启用");

                entity.Property(e => e.LastModificationTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.LastModifierUserId).HasComment("修改用户");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.Status).HasComment("状态");

                entity.Property(e => e.Tenant).HasComment("租户");
            });

            modelBuilder.Entity<NotifyTemplet>(entity =>
            {
                entity.ToTable("Notify_Templet");

                entity.HasComment("系统邮件模板");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Code).HasComment("外部编码");

                entity.Property(e => e.CreationTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatorUserId).HasComment("创建用户");

                entity.Property(e => e.DeleterUserId).HasComment("删除用户");

                entity.Property(e => e.DeletionTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.DisplayTemplet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasComment("显示内容");

                entity.Property(e => e.IsDeleted).HasComment("是否删除");

                entity.Property(e => e.LastModificationTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.LastModifierUserId).HasComment("修改用户");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasComment("审核备注");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.SignId).HasComment("签名Id");

                entity.Property(e => e.Status).HasComment("未审核/审核中/审核成功/审核失败");

                entity.Property(e => e.Templet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasComment("模板内容");

                entity.Property(e => e.Tenant).HasComment("租户");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasComment("标题");

                entity.Property(e => e.Type).HasComment("类型");
            });

            modelBuilder.Entity<OrderAfterSale>(entity =>
            {
                entity.Property(e => e.ApplyReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.ApplyType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactWay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InnerStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperateMessage).HasMaxLength(500);

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickupAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionDescribe)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiveAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnWay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updatetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderAfterSaleFlow>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InnerStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.OperateMessage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OperateType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperateUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderAfterSalePhoto>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.PhotoUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderArchive>(entity =>
            {
                entity.HasIndex(e => new { e.OrderId, e.Page })
                    .HasName("IX_OrderArchive")
                    .IsUnique();

                entity.Property(e => e.PhotoUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderBox>(entity =>
            {
                entity.HasIndex(e => new { e.OrderId, e.BoxId })
                    .HasName("IX_OrderBox")
                    .IsUnique();

                entity.Property(e => e.PackageNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.PrintNum).HasComment("包裹码打印次数");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("包裹的状态：未处理，已打印，已打包，已装车.");

                entity.Property(e => e.StoreZone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("包裹所在区域");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderCheckoutLog>(entity =>
            {
                entity.HasComment("订单结账日志");

                entity.HasIndex(e => e.Tenant)
                    .HasName("Tenant");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.CheckoutTime)
                    .HasColumnType("datetime")
                    .HasComment("结账时间");

                entity.Property(e => e.CreationTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatorUserId).HasComment("创建用户");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.Tenant).HasComment("租户");
            });

            modelBuilder.Entity<OrderDelivery>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CarId).HasComment("车辆Id");

                entity.Property(e => e.CarUserId).HasComment("车辆司机Id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("装车状态");

                entity.Property(e => e.StockOutUserId).HasComment("出库员Id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderDeliveryBox>(entity =>
            {
                entity.HasIndex(e => e.OrderBoxId)
                    .HasName("IX_OrderDeliveryBox")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasIndex(e => new { e.OrderId, e.GoodsId })
                    .HasName("IX_OrderDetail")
                    .IsUnique();

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("money");

                entity.Property(e => e.Afc)
                    .HasColumnName("AFC")
                    .HasColumnType("money");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayNoTaxPrice).HasColumnType("money");

                entity.Property(e => e.DisplayPrice).HasColumnType("money");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.GrossProfitPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGift).HasComment("是否是赠品");

                entity.Property(e => e.NoTaxAmount).HasColumnType("money");

                entity.Property(e => e.NoTaxPrice).HasColumnType("money");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PurchaseMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxRate).HasColumnType("money");
            });

            modelBuilder.Entity<OrderDistribution>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasComment("订单所属Branch");

                entity.Property(e => e.InvoiceChargeOff)
                    .HasColumnType("money")
                    .HasComment("收票状态");

                entity.Property(e => e.InvoiceStatus).HasComment("收票金额");

                entity.Property(e => e.OrderId).HasComment("订单编号");

                entity.Property(e => e.OriginalBranchId).HasComment("订单最原始的BranchId");

                entity.Property(e => e.PayChargeOff)
                    .HasColumnType("money")
                    .HasComment("付款金额");

                entity.Property(e => e.PayStatus).HasComment("付款状态");

                entity.Property(e => e.PbranchId)
                    .HasColumnName("PBranchId")
                    .HasComment("订单所属Branch的父Branch");

                entity.Property(e => e.SumMoney)
                    .HasColumnType("money")
                    .HasComment("上级抽层后的订单总额");

                entity.Property(e => e.UserId).HasComment("分配人员");
            });

            modelBuilder.Entity<OrderDistributionDetail>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("上级抽层后的金额");

                entity.Property(e => e.OrderDistributionId).HasComment("分销订单与集团成员关联表Id");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasComment("上级抽层后的单价");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderGoodsComments>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderInvoiceInfo>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("购方地址");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("购方开户行");

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("购方开户行账号");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方发票内容");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方电子邮箱");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("发票备注");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方手机号");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasComment("购方发票抬头");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方注册电话");

                entity.Property(e => e.TaxNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方税号");

                entity.Property(e => e.Type).HasComment("发票类型");
            });

            modelBuilder.Entity<OrderLog>(entity =>
            {
                entity.Property(e => e.IsInner).HasComment("1:内部可见；0：客户可见");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OrderModify>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_OrderModify");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.NewPrice).HasColumnType("money");

                entity.Property(e => e.NewTaxRate).HasColumnType("money");

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.OldTaxRate).HasColumnType("money");

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')")
                    .HasComment("订单修改后，自动生成 采购单时用到的状态");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderModifyAc>(entity =>
            {
                entity.ToTable("OrderModifyAC");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.GrossProfit)
                    .HasColumnType("money")
                    .HasComment("毛利");

                entity.Property(e => e.ModifyAcid).HasColumnName("ModifyACId");

                entity.Property(e => e.NewAc)
                    .HasColumnName("NewAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NewGrossProfit).HasColumnType("money");

                entity.Property(e => e.NewGrossProfitPercent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldAc)
                    .HasColumnName("OldAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldGrossProfitPercent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SumMoney)
                    .HasColumnType("money")
                    .HasComment("订单金额");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderPicking>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_OrderPicking")
                    .IsUnique();

                entity.Property(e => e.DistributeUserId).HasComment("分单员");

                entity.Property(e => e.PickingUserId).HasComment("理货员Id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderPickingLog>(entity =>
            {
                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderReceiveMoney>(entity =>
            {
                entity.Property(e => e.ChargeOff)
                    .HasColumnType("money")
                    .HasComment("销账金额");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("付款方式");

                entity.Property(e => e.ReceiveAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney)
                    .HasColumnType("money")
                    .HasComment("收款金额");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderReceiveMoneyDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.GoodsName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderStatement>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_OrderStatement");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NeedToInvoice).HasColumnType("money");

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SumGoodsAmount).HasColumnType("money");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OrderStatementCrossInvoice>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderStatementDetail>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_OrderStatementDetail")
                    .IsUnique();
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasIndex(e => e.Guid)
                    .HasName("IX_Orders_GUID");

                entity.HasIndex(e => new { e.BranchId, e.CustomerId, e.MemberId })
                    .HasName("IX_Orders_1");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyId).HasComment("VIPApply的Id");

                entity.Property(e => e.ArchivedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00.000')");

                entity.Property(e => e.AuditRemark).HasMaxLength(300);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BranchId)
                    .HasDefaultValueSql("((1))")
                    .HasComment("SYNAct客户Id");

                entity.Property(e => e.ChargeOff).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConfirmFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasComment("客户Id，个人客户则为0");

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptId).HasComment("Member所在部门的Id");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate)
                    .HasColumnType("datetime")
                    .HasComment("订单完成时间");

                entity.Property(e => e.Freight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossProfit)
                    .HasColumnType("money")
                    .HasComment("毛利");

                entity.Property(e => e.GrossProfitPercent).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("添加订单，根据GUID得到 订单的Id");

                entity.Property(e => e.IName)
                    .HasColumnName("I_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("接口：单位名称");

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("接口：订单Id");

                entity.Property(e => e.InvoiceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('纸质发票')");

                entity.Property(e => e.InvoiceContent)
                    .HasMaxLength(4000)
                    .HasComment("发票内容");

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("发票抬头");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票类型");

                entity.Property(e => e.IsArchive).HasComment("是否已经归档");

                entity.Property(e => e.IsConfirm)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCopied).HasComment("是否被复制");

                entity.Property(e => e.IsDelete).HasComment("1 删除的订单");

                entity.Property(e => e.IsEmergency).HasComment("是否紧急，1：紧急订单");

                entity.Property(e => e.IsEnable).HasComment("0:草稿 1:正式订单");

                entity.Property(e => e.IsInner).HasComment("1:内部可见，客户端对账不可见，主要用于");

                entity.Property(e => e.IsInvoice).HasComment("1:开发票；0：不开发票");

                entity.Property(e => e.IsShowAmountInPrint)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsStorage).HasComment("是否已经入库，Member库存管理时使用");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.OrderAmount).HasColumnType("money");

                entity.Property(e => e.OrderTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("下单时间");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .HasComment("订单类型");

                entity.Property(e => e.PayAmount).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .HasComment("付款状态");

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("支付方式");

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.Property(e => e.PlanDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("计划配送日期");

                entity.Property(e => e.Point)
                    .HasColumnType("money")
                    .HasComment("积分");

                entity.Property(e => e.PrintTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('未处理')");

                entity.Property(e => e.RawOrderId).HasComment("原订单Id");

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("收货人姓名");

                entity.Property(e => e.SalesId).HasComment("业务员Id，统计业绩时用");

                entity.Property(e => e.ServiceFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFinishTime).HasColumnType("datetime");

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney)
                    .HasColumnType("money")
                    .HasComment("订单金额");

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("最近更新时间");

                entity.Property(e => e.UserId).HasComment("下单人Id");

                entity.Property(e => e.Usercode)
                    .HasColumnName("usercode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParamGather>(entity =>
            {
                entity.Property(e => e.ParamsName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayLog>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlatformInfo>(entity =>
            {
                entity.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                entity.Property(e => e.PlatformCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PlatformName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PreGoodsPhoto>(entity =>
            {
                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreInvoice>(entity =>
            {
                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InitialAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRemark)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreInvoiceAmount).HasColumnType("money");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PrintTempletDic>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Vuale)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProGoodsType>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsLeaf)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PointRate).HasDefaultValueSql("((100))");

                entity.Property(e => e.PriceArea)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Py)
                    .HasColumnName("PY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProductGoodsType>(entity =>
            {
                entity.ToTable("Product_GoodsType");

                entity.Property(e => e.DonvvTypeId).HasComment("Donvv产品库的商品分类Id");

                entity.Property(e => e.DonvvTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Donvv产品库的商品分类名称");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.ToTable("Product_Info");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SourceUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2017-04-17')");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.EstimateRecieveDate)
                    .HasColumnType("datetime")
                    .HasComment("预计到货时间或者预计收货时间");

                entity.Property(e => e.IsChecked).HasComment("是否对账");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NeedToPurchaseId).HasComment("采购汇总单Id");

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("付款状态");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PutInStoreTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-1-1')");

                entity.Property(e => e.ReceiptUserId).HasComment("收货员Id");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("供应商反馈状态");

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasComment("生成采购单人员的Id");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.HasIndex(e => e.PurchaseId)
                    .HasName("I_PurchaseId");

                entity.HasIndex(e => new { e.GoodsId, e.PurchaseId })
                    .HasName("IX_PurchaseDetail")
                    .IsUnique();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BillsPrice)
                    .HasColumnType("money")
                    .HasComment("开单价");

                entity.Property(e => e.DelayDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DetailMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvBrandId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvBrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice)
                    .HasColumnType("money")
                    .HasComment("换算后的进价");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxAmount).HasColumnType("money");

                entity.Property(e => e.NoTaxInPrice).HasColumnType("money");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxRate).HasColumnType("money");
            });

            modelBuilder.Entity<PurchaseLog>(entity =>
            {
                entity.HasIndex(e => e.PurchaseId)
                    .HasName("IX_PurchaseLog");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PurchaseStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchaseMerge>(entity =>
            {
                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchaseModify>(entity =>
            {
                entity.HasIndex(e => e.PurchaseId)
                    .HasName("IX_PurchaseModify");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.NewNoTaxPrice).HasColumnType("money");

                entity.Property(e => e.NewPrice).HasColumnType("money");

                entity.Property(e => e.NewTaxRate).HasColumnType("money");

                entity.Property(e => e.OldNoTaxPrice).HasColumnType("money");

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.OldTaxRate).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchasePay>(entity =>
            {
                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("全额付款，部分付款，补足余款，优惠付款");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PurchasePayDetail>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("明细实收金额");

                entity.Property(e => e.ChargeOffAmount)
                    .HasColumnType("money")
                    .HasComment("明细销账金额");

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.PayId).HasComment("采购付款记录表Id");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchaseQuote>(entity =>
            {
                entity.HasComment("采购单报价表");

                entity.Property(e => e.Id).HasComment("主键");

                entity.Property(e => e.BranchId).HasComment("租户编号");

                entity.Property(e => e.DonvvBrandId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("品牌库品牌编号");

                entity.Property(e => e.DonvvBrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("品牌库品牌名称");

                entity.Property(e => e.DonvvSupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("品牌库供应商编号");

                entity.Property(e => e.DonvvSupplierName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("品牌库供应商名称");

                entity.Property(e => e.PurchaseId).HasComment("采购单号");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('未处理')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<PurchaseQuoteDetail>(entity =>
            {
                entity.HasComment("采购报价单明细");

                entity.Property(e => e.Id).HasComment("主键");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("金额");

                entity.Property(e => e.DonvvSku)
                    .HasColumnName("DonvvSKU")
                    .HasComment("品牌库商品编号");

                entity.Property(e => e.GoodsId).HasComment("商品编号");

                entity.Property(e => e.Num).HasComment("商品数量");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasComment("价格");

                entity.Property(e => e.PurchaseQuoteId).HasComment("采购报价单号");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("单位");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<PurchaseStatement>(entity =>
            {
                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_PurchaseStatement");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('未付款')")
                    .HasComment("未付款、已付款、部分付款");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PurchaseStatementDetail>(entity =>
            {
                entity.HasIndex(e => e.PurchaseId)
                    .HasName("IX_PurchaseId")
                    .IsUnique();

                entity.HasIndex(e => new { e.PurchaseId, e.PurchaseStatementId })
                    .HasName("IX_PurchaseStatementDetail");
            });

            modelBuilder.Entity<Quotation>(entity =>
            {
                entity.Property(e => e.QuotationTime).HasColumnType("datetime");

                entity.Property(e => e.ValidTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegisterProtocol>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProtocolContent)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProtocolName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SalesPlan>(entity =>
            {
                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.PlanDate).HasColumnType("date");

                entity.Property(e => e.PlanMoney).HasColumnType("money");

                entity.Property(e => e.SalesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SalesStoreMap>(entity =>
            {
                entity.Property(e => e.IsEnable).HasComment("是否启用");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .HasComment("销售员名称");

                entity.Property(e => e.SalesNo).HasComment("销售员Id");

                entity.Property(e => e.StoreId).HasComment("仓库Id");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .HasComment("仓库名称");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("更新日期");
            });

            modelBuilder.Entity<ServiceOrder>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ApplyUserName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.LastPrintTime)
                    .HasColumnType("datetime")
                    .HasComment("上一次/最近一次打印的时间");

                entity.Property(e => e.PlantTime).HasColumnType("datetime");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.SumMoney).HasColumnType("money");
            });

            modelBuilder.Entity<ServiceOrderDelivery>(entity =>
            {
                entity.Property(e => e.CarId).HasComment("车辆编号");

                entity.Property(e => e.CarUserId).HasComment("送货员编号");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("状态");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiceOrderDeliveryDetail>(entity =>
            {
                entity.Property(e => e.DeliveryId).HasComment("装车编号");

                entity.Property(e => e.OrderId).HasComment("订单编号");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiceOrderDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ServiceOrderItem>(entity =>
            {
                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(200);
            });

            modelBuilder.Entity<ServiceOrderLog>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SiChuanLog>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(2000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourceGoods>(entity =>
            {
                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.SourceBrand)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("抓取商品品牌");

                entity.Property(e => e.SourceCategory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("抓取商品分类");

                entity.Property(e => e.SourceId).HasComment("抓取商品来源");

                entity.Property(e => e.SourceMainSku)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("抓取商品主SKU");

                entity.Property(e => e.SourcePrice)
                    .HasColumnType("money")
                    .HasComment("抓取商品售价");

                entity.Property(e => e.SourceSku)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("抓取商品SKU");

                entity.Property(e => e.SpecVals)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("抓取商品规格信息");

                entity.Property(e => e.TargetGoodsId).HasComment("目标商品编号");

                entity.Property(e => e.TargetParentId).HasComment("母商品编号");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("抓取商品Url");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasIndex(e => new { e.BranchId, e.Name })
                    .HasName("IX_Store")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StoreZone>(entity =>
            {
                entity.HasIndex(e => new { e.StoreId, e.Code })
                    .HasName("IX_StoreZone");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StrategyGrossProfit>(entity =>
            {
                entity.ToTable("Strategy_GrossProfit");

                entity.HasComment("商品毛利策略");

                entity.HasIndex(e => e.CreationTime)
                    .HasName("Index_CreationTime");

                entity.HasIndex(e => e.EndTime)
                    .HasName("Index_EndTime");

                entity.HasIndex(e => e.StartTime)
                    .HasName("Index_StartTime");

                entity.HasIndex(e => e.Tenant)
                    .HasName("Index_Tenant");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.CreationTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatorUserId).HasComment("创建用户");

                entity.Property(e => e.DeleterUserId).HasComment("删除用户");

                entity.Property(e => e.DeletionTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.Extend1).HasComment("扩展参数");

                entity.Property(e => e.Extend2)
                    .HasMaxLength(200)
                    .HasComment("扩展参数");

                entity.Property(e => e.IsDeleted).HasComment("是否删除");

                entity.Property(e => e.IsEnabled).HasComment("是否启用");

                entity.Property(e => e.LastModificationTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.LastModifierUserId).HasComment("修改用户");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("策略名称");

                entity.Property(e => e.Privilege).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.Tenant).HasComment("租户");

                entity.Property(e => e.Term).HasComment("条件  1、开单 2、pc 3、m 4、门店");

                entity.Property(e => e.Way).HasComment("方式  1、禁止  2、提醒  3、通知  4、审核");
            });

            modelBuilder.Entity<StrategyItem>(entity =>
            {
                entity.HasComment("策略规则明细");

                entity.HasIndex(e => e.ItemId)
                    .HasName("Index_ItemId");

                entity.HasIndex(e => e.TypeId)
                    .HasName("Index_TypeId");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.Extend1).HasComment("扩展参数");

                entity.Property(e => e.Extend2)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("扩展参数");

                entity.Property(e => e.Extend3)
                    .HasMaxLength(200)
                    .HasComment("扩展参数");

                entity.Property(e => e.ItemId).HasComment("明细Id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("明细名称");

                entity.Property(e => e.Mode).HasComment("模式 包含/排查");

                entity.Property(e => e.Type).HasComment("类型  用户/角色/部门");

                entity.Property(e => e.TypeId).HasComment("策略规则Id");
            });

            modelBuilder.Entity<StrategyOrigin>(entity =>
            {
                entity.HasComment("策略明细");

                entity.HasIndex(e => e.StrategyId)
                    .HasName("Index_StrategyId");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.Extend1).HasComment("扩展参数");

                entity.Property(e => e.Extend2)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("扩展参数");

                entity.Property(e => e.Extend3)
                    .HasMaxLength(200)
                    .HasComment("扩展参数");

                entity.Property(e => e.MaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("界限值-最大值");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("界限值-最小值");

                entity.Property(e => e.Mode).HasComment("无/值/范围/选项");

                entity.Property(e => e.RangeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("界限值");

                entity.Property(e => e.StrategyId).HasComment("策略Id");

                entity.Property(e => e.TargetAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("目标值");
            });

            modelBuilder.Entity<StrategyRange>(entity =>
            {
                entity.HasComment("策略界限");

                entity.HasIndex(e => e.ItemId)
                    .HasName("Index_ItemId");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.Extend1).HasComment("扩展参数");

                entity.Property(e => e.Extend2)
                    .HasMaxLength(200)
                    .HasComment("扩展参数");

                entity.Property(e => e.ItemId).HasComment("明细Id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("明细名称");

                entity.Property(e => e.Mode).HasComment("模式 包含/排查");

                entity.Property(e => e.StrategyId).HasComment("策略Id");

                entity.Property(e => e.Type).HasComment("类型 类目/品牌//明细");
            });

            modelBuilder.Entity<StrategyRule>(entity =>
            {
                entity.HasComment("策略规则");

                entity.HasIndex(e => e.StrategyId)
                    .HasName("Index_StrategyId");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.Extend1).HasComment("扩展参数");

                entity.Property(e => e.Extend2)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("扩展参数");

                entity.Property(e => e.Extend3)
                    .HasMaxLength(200)
                    .HasComment("扩展参数");

                entity.Property(e => e.MaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("界限值-最大值");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("界限值-最小值");

                entity.Property(e => e.Mode).HasComment("无/值/范围/选项");

                entity.Property(e => e.RangeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("界限值");

                entity.Property(e => e.StrategyId).HasComment("策略Id");

                entity.Property(e => e.TargetAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("目标值");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Attitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("供应商对我们的重视程度");

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DonvvSupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票类型");

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MainBrand)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("主营品牌");

                entity.Property(e => e.Major)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("主营业务范围");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("供应商名称");

                entity.Property(e => e.OpeningBank)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('lueSGJZetyySpUndWjMBEg==')");

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("结款方式");

                entity.Property(e => e.Py)
                    .HasColumnName("PY")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("简称");

                entity.Property(e => e.SupplierTaxNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("供应商类型");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SupplierContacts>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Moblie).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telphone).HasMaxLength(50);
            });

            modelBuilder.Entity<SupplierDepartment>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SupplierInvoice>(entity =>
            {
                entity.Property(e => e.Id).HasComment("收供应商发票表主键，自增ID");

                entity.Property(e => e.BranchId).HasComment("懂微SAAS平台用户ID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasDefaultValueSql("('')")
                    .HasComment("发票内容");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("发票代码");

                entity.Property(e => e.InvoiceCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasComment("发票开票日期");

                entity.Property(e => e.InvoiceMoney)
                    .HasColumnType("money")
                    .HasComment("发票金额");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("发票抬头");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票号码");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发票类型");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("备注");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnType("datetime")
                    .HasComment("收到发票日期，默认系统录入时间");

                entity.Property(e => e.SupplierId).HasComment("供应商ID");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("保存收票信息系统时间");

                entity.Property(e => e.UserId).HasComment("操作者ID");
            });

            modelBuilder.Entity<SupplierInvoiceDetails>(entity =>
            {
                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToInvoiceMoney).HasColumnType("money");
            });

            modelBuilder.Entity<SupplierPrepayment>(entity =>
            {
                entity.Property(e => e.ActualPayTime).HasColumnType("datetime");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasComment("余额");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((1))");

                entity.Property(e => e.InitialBalance)
                    .HasColumnType("money")
                    .HasComment("期初金额");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasComment("备注");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("操作(预付、付款、撤销)");

                entity.Property(e => e.OperatorId).HasComment("操作人Id");

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作人名称");

                entity.Property(e => e.PayAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Payment)
                    .HasColumnType("money")
                    .HasComment("付款金额");

                entity.Property(e => e.Prepayment)
                    .HasColumnType("money")
                    .HasComment("预付金额");

                entity.Property(e => e.PurchaseStatementId).HasComment("对账单Id");

                entity.Property(e => e.SupplierId).HasComment("供应商Id");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("供应商名称");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<SupplierSettleAccounts>(entity =>
            {
                entity.Property(e => e.Id).HasComment("供应商结账表主键，自增ID");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasComment("余额（可手工调整）=上次余额+区间付款金额-区间收发票金额");

                entity.Property(e => e.BranchId).HasComment("懂微SAAS平台用户ID");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnType("money")
                    .HasComment("区间收发票金额");

                entity.Property(e => e.LastTimeBalance)
                    .HasColumnType("money")
                    .HasComment("上次结账的余额");

                entity.Property(e => e.LastTimeSadate)
                    .HasColumnName("LastTimeSADate")
                    .HasColumnType("datetime")
                    .HasComment("上一次结账截止时间，若为第一次结账，则值为1900-1-1");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("备注");

                entity.Property(e => e.PurchaseAmount)
                    .HasColumnType("money")
                    .HasComment("区间采购金额");

                entity.Property(e => e.PurchasePayAmount)
                    .HasColumnType("money")
                    .HasComment("区间付款金额");

                entity.Property(e => e.SettleAccountDate)
                    .HasColumnType("datetime")
                    .HasComment("结账截止时间");

                entity.Property(e => e.SupplierId).HasComment("供应商ID");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("保存结账信息时的系统时间");

                entity.Property(e => e.UserId).HasComment("操作者ID");
            });

            modelBuilder.Entity<SurveysFeedBack>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Opinion).HasMaxLength(3000);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Satisfaction)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysAgent>(entity =>
            {
                entity.ToTable("Sys_Agent");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Sys_Agent")
                    .IsUnique();

                entity.Property(e => e.AcountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Bank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasComment("推荐代理商Id，预备以后多级提成制度");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysAgentUsers>(entity =>
            {
                entity.ToTable("Sys_Agent_Users");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysApprove>(entity =>
            {
                entity.ToTable("Sys_Approve");

                entity.Property(e => e.ApproveAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveAt).HasColumnType("datetime");

                entity.Property(e => e.ApproveCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.KeyId)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysAuthorize>(entity =>
            {
                entity.ToTable("Sys_Authorize");

                entity.Property(e => e.AuthorizeYear).HasDefaultValueSql("((1))");

                entity.Property(e => e.Money).HasColumnType("money");

                entity.Property(e => e.NewExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.OldExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('未付款')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranch>(entity =>
            {
                entity.ToTable("Sys_Branch");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Sys_Branch")
                    .IsUnique();

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityAlias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CitySort).HasDefaultValueSql("((10))");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Domain2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvDomain)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("截止有效期：过期后系统将不能登录");

                entity.Property(e => e.Introduction).HasColumnType("text");

                entity.Property(e => e.IsEnable)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否有效");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("分支机构名称");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceSort).HasDefaultValueSql("((10))");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNum).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysBranchActivity>(entity =>
            {
                entity.ToTable("Sys_BranchActivity");

                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_Sys_BranchActivity");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhotoPath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchActivityContent>(entity =>
            {
                entity.ToTable("Sys_BranchActivityContent");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_ActivityId");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysBranchActivityGift>(entity =>
            {
                entity.ToTable("Sys_BranchActivityGift");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_ActivityId");

                entity.HasIndex(e => e.ActivityRuleId)
                    .HasName("IX_ActivityRuleId");

                entity.HasIndex(e => e.GoodsId)
                    .HasName("IX_GoodsId");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchActivityRange>(entity =>
            {
                entity.ToTable("Sys_BranchActivityRange");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_ActivityId");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchActivityRule>(entity =>
            {
                entity.ToTable("Sys_BranchActivityRule");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_ActivityId");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.Property(e => e.RangeAmount).HasColumnType("money");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchAds>(entity =>
            {
                entity.ToTable("Sys_BranchAds");

                entity.Property(e => e.Href1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchArea>(entity =>
            {
                entity.ToTable("Sys_BranchArea");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackGroundColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Href2)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Href3)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Href4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image7)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image8)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LeftLayout)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchAreaDetail>(entity =>
            {
                entity.ToTable("Sys_BranchAreaDetail");

                entity.Property(e => e.Alt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Href)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sort).HasDefaultValueSql("((99))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchAreas>(entity =>
            {
                entity.ToTable("Sys_BranchAreas");

                entity.HasIndex(e => new { e.BranchId, e.Name })
                    .HasName("IX_Sys_BranchAreas");

                entity.Property(e => e.BorderColor)
                    .IsRequired()
                    .HasColumnName("Border_color")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BorderWidth).HasColumnName("Border_width");

                entity.Property(e => e.ColSpace).HasColumnName("Col_Space");

                entity.Property(e => e.ColWidth).HasColumnName("Col_Width");

                entity.Property(e => e.HeaderBackGroundColor)
                    .IsRequired()
                    .HasColumnName("Header_BackGroundColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderFontColor)
                    .IsRequired()
                    .HasColumnName("Header_FontColor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderFontSize).HasColumnName("Header_FontSize");

                entity.Property(e => e.HeaderHeight).HasColumnName("Header_Height");

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowHeight).HasColumnName("Row_Height");

                entity.Property(e => e.RowSpace).HasColumnName("Row_Space");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchAuth>(entity =>
            {
                entity.ToTable("Sys_BranchAuth");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchBankInfo>(entity =>
            {
                entity.ToTable("Sys_BranchBankInfo");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("户名（公司名称）");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("账号");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("开户行");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchCss>(entity =>
            {
                entity.ToTable("Sys_Branch_CSS");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchEmailSetting>(entity =>
            {
                entity.ToTable("Sys_BranchEmailSetting");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("发信邮箱地址");

                entity.Property(e => e.IsCheck).HasComment("是否检验邮箱");

                entity.Property(e => e.IsEnableSsl)
                    .HasColumnName("IsEnableSSL")
                    .HasComment("是否使用安全链接（SSL）");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("发信人昵称");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("登录密码");

                entity.Property(e => e.Smtpserver)
                    .IsRequired()
                    .HasColumnName("SMTPServer")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发信服务器");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("登录账号");
            });

            modelBuilder.Entity<SysBranchErpsetting>(entity =>
            {
                entity.ToTable("Sys_BranchERPSetting");

                entity.Property(e => e.Erpname)
                    .IsRequired()
                    .HasColumnName("ERPName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IconUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchFloor>(entity =>
            {
                entity.ToTable("Sys_BranchFloor");

                entity.Property(e => e.AutoSub)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BackGroundColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FloorName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Href1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Href2)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Href3)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LeftLayout)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("左侧广告位布局，枚举：整体、上下、上左右");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchFloorBrandingWall>(entity =>
            {
                entity.ToTable("Sys_BranchFloorBrandingWall");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchFloorBrandingWallPhotos>(entity =>
            {
                entity.ToTable("Sys_BranchFloorBrandingWallPhotos");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.ImgHref)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.ImgPath)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchFloorDisplayType>(entity =>
            {
                entity.ToTable("Sys_BranchFloorDisplayType");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchGoodsType>(entity =>
            {
                entity.ToTable("Sys_BranchGoodsType");

                entity.Property(e => e.IsFloor)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否需要在楼层中显示数据");

                entity.Property(e => e.Sort)
                    .HasDefaultValueSql("((10))")
                    .HasComment("首页大类和Floor中的显示顺序");

                entity.Property(e => e.TypeId).HasComment("商品类别ID");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchHelp>(entity =>
            {
                entity.ToTable("Sys_BranchHelp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchHelpContent>(entity =>
            {
                entity.ToTable("Sys_BranchHelpContent");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchHelpGroup>(entity =>
            {
                entity.ToTable("Sys_BranchHelpGroup");

                entity.Property(e => e.IsLocked).HasComment("是否锁定，锁定后不允许修改");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchHelpGroupPrivateInfo>(entity =>
            {
                entity.ToTable("Sys_BranchHelpGroupPrivateInfo");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("帮助文件一级分类的自定义名");

                entity.Property(e => e.GroupId).HasComment("帮助文件一级分类Id");

                entity.Property(e => e.IsDisable).HasComment("是否禁用");

                entity.Property(e => e.Sort)
                    .HasDefaultValueSql("((99))")
                    .HasComment("排序");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchHelpPrivateInfo>(entity =>
            {
                entity.ToTable("Sys_BranchHelpPrivateInfo");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("帮助文件一级分类的自定义名");

                entity.Property(e => e.HelpId).HasComment("帮助文件二级分类Id");

                entity.Property(e => e.IsDisable).HasComment("是否禁用");

                entity.Property(e => e.Sort)
                    .HasDefaultValueSql("((99))")
                    .HasComment("排序");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchHotWords>(entity =>
            {
                entity.ToTable("Sys_BranchHotWords");

                entity.Property(e => e.HotWords)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Href)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sort).HasDefaultValueSql("((10))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchPay>(entity =>
            {
                entity.ToTable("Sys_BranchPay");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AppId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("账号");

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.BizType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CertFileUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("合作者ID");

                entity.Property(e => e.PublicKey)
                    .HasColumnName("Public_key")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Secret)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasComment("应用秘钥");

                entity.Property(e => e.Sort).HasDefaultValueSql("((99))");

                entity.Property(e => e.SslcertPath)
                    .HasColumnName("Sslcert_path")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysBranchPayment>(entity =>
            {
                entity.ToTable("Sys_BranchPayment");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.ApiPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PoundageAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysBranchSeo>(entity =>
            {
                entity.ToTable("Sys_BranchSeo");

                entity.HasComment("站点seo");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Code)
                    .HasMaxLength(2000)
                    .HasComment("SEO代码");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(200)
                    .HasComment("关键字");

                entity.Property(e => e.Tenant).HasComment("租户");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasComment("标题");
            });

            modelBuilder.Entity<SysBranchServicePromise>(entity =>
            {
                entity.ToTable("Sys_BranchServicePromise");

                entity.Property(e => e.ColWidth).HasColumnName("Col_Width");

                entity.Property(e => e.RowHeight).HasColumnName("Row_Height");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchServicePromiseDetail>(entity =>
            {
                entity.ToTable("Sys_BranchServicePromiseDetail");

                entity.Property(e => e.Href)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchSetting>(entity =>
            {
                entity.ToTable("Sys_BranchSetting");

                entity.Property(e => e.Id).HasComment("是否显示虚拟销量，用于");

                entity.Property(e => e.BranchIdOfHideMoney)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchSite).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerManageId).HasDefaultValueSql("('0')");

                entity.Property(e => e.CustomerNeedApprove).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefaultStore)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsRepeatGoodsSn).HasColumnName("IsRepeatGoodsSN");

                entity.Property(e => e.IsShowInvalidPurchaser).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderConfirmGift)
                    .HasColumnName("OrderConfirm_Gift")
                    .HasComment("订单审核：赠品模式时  1 开启此功能 0 不开启此功能");

                entity.Property(e => e.OrderConfirmPriceLessInPrice)
                    .HasColumnName("OrderConfirm_PriceLessInPrice")
                    .HasComment("订单审核：销售开单售价低于进价时 1 开启此功能 0 不开启此功能");

                entity.Property(e => e.OrderConfirmReturnDirectDelivery).HasColumnName("OrderConfirm_ReturnDirectDelivery");

                entity.Property(e => e.OrderDefaultTaxRate).HasColumnType("money");

                entity.Property(e => e.OrderToDistribution).HasComment("销售单转分销单");

                entity.Property(e => e.PurchaseCollectDefaultPurchaser).HasColumnName("PurchaseCollect_DefaultPurchaser");

                entity.Property(e => e.PurchaseDefaultTaxRate).HasColumnType("money");

                entity.Property(e => e.SpecifySupplier).HasComment("高级设置：汇总开单的时候，是否必须指定供应商，默认为否，");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysBranchSiteFooter>(entity =>
            {
                entity.ToTable("Sys_BranchSiteFooter");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<SysBranchSiteSetting>(entity =>
            {
                entity.ToTable("Sys_BranchSiteSetting");

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyTelphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HtmlValidate)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IconUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IcpNo)
                    .IsRequired()
                    .HasColumnName("ICP_No")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qq)
                    .IsRequired()
                    .HasColumnName("QQ")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qrcode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubTelphone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UseGoodsTypes).HasComment("是否启用自选商品分类");

                entity.Property(e => e.UseQqcustomer).HasColumnName("UseQQCustomer");

                entity.Property(e => e.UseTopMenus).HasComment("是否自选一级菜单");

                entity.Property(e => e.VerificationCodeName).HasMaxLength(20);
            });

            modelBuilder.Entity<SysBranchSiteSolution>(entity =>
            {
                entity.ToTable("Sys_BranchSiteSolution");

                entity.HasComment("解决方案");

                entity.HasIndex(e => e.Tenant)
                    .HasName("Index_Tenant");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.CreationTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatorUserId).HasComment("创建用户");

                entity.Property(e => e.DeleterUserId).HasComment("删除用户");

                entity.Property(e => e.DeletionTime)
                    .HasColumnType("datetime")
                    .HasComment("删除时间");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("图片");

                entity.Property(e => e.IsDeleted).HasComment("是否删除");

                entity.Property(e => e.LastModificationTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.LastModifierUserId).HasComment("修改用户");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("名称");

                entity.Property(e => e.Order).HasComment("排序");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.Tenant).HasComment("租户");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .HasComment("链接");
            });

            modelBuilder.Entity<SysBranchTheme>(entity =>
            {
                entity.ToTable("Sys_BranchTheme");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchThemeArea>(entity =>
            {
                entity.ToTable("Sys_BranchThemeArea");

                entity.Property(e => e.ColSpace).HasColumnName("Col_Space");

                entity.Property(e => e.ColWidth).HasColumnName("Col_Width");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.RowHeight).HasColumnName("Row_Height");

                entity.Property(e => e.RowSpace).HasColumnName("Row_Space");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchThemeAreaGoodsTab>(entity =>
            {
                entity.ToTable("Sys_BranchThemeAreaGoodsTab");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SearchType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TabHref)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchThemeAreaPhoto>(entity =>
            {
                entity.ToTable("Sys_BranchThemeAreaPhoto");

                entity.Property(e => e.ImgHref)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysBranchThirdParty>(entity =>
            {
                entity.ToTable("Sys_BranchThirdParty");

                entity.HasComment("第三方入驻");

                entity.Property(e => e.Id).HasComment("PK");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("名称");

                entity.Property(e => e.Tenant).HasComment("租户");
            });

            modelBuilder.Entity<SysBranchTopMenu>(entity =>
            {
                entity.ToTable("Sys_BranchTopMenu");

                entity.Property(e => e.IsBlank)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sort).HasDefaultValueSql("((10))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysCanvassAgreement>(entity =>
            {
                entity.ToTable("Sys_CanvassAgreement");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Text).HasColumnType("text");
            });

            modelBuilder.Entity<SysCar>(entity =>
            {
                entity.ToTable("Sys_Car");

                entity.HasIndex(e => new { e.BranchId, e.Plate })
                    .HasName("IX_Sys_Car")
                    .IsUnique();

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysCarLog>(entity =>
            {
                entity.ToTable("Sys_CarLog");

                entity.Property(e => e.Kil)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("里程");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oil)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("加油量");

                entity.Property(e => e.OilMoney)
                    .HasColumnType("money")
                    .HasComment("加油金额");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysCarUser>(entity =>
            {
                entity.ToTable("Sys_CarUser");

                entity.HasIndex(e => new { e.CarId, e.UserId })
                    .HasName("IX_Sys_CarUser");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysCity>(entity =>
            {
                entity.ToTable("Sys_City");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_Config");

                entity.HasComment("系统配置表");

                entity.Property(e => e.BranchId).HasComment("租户");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("键");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("值");
            });

            modelBuilder.Entity<SysDept>(entity =>
            {
                entity.ToTable("Sys_Dept");

                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_Sys_Dept");

                entity.Property(e => e.BranchId).HasComment("所属分支机构");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("部门名称");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysDictionary>(entity =>
            {
                entity.ToTable("Sys_Dictionary");

                entity.HasComment("编码");

                entity.Property(e => e.Id)
                    .HasComment("主键ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("编码描述说明");

                entity.Property(e => e.EnglishName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码英文");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.IsDelete).HasComment("是否删除");

                entity.Property(e => e.IsEnable).HasComment("是否启用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编码名称");

                entity.Property(e => e.ParentId).HasComment("上级编号");

                entity.Property(e => e.Sort).HasComment("编码顺序");

                entity.Property(e => e.TypeId).HasComment("编码类型Id");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("类型名称");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改人");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SysDictionary)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_DICT_Relation_SYS_DICT");
            });

            modelBuilder.Entity<SysDictionaryType>(entity =>
            {
                entity.ToTable("Sys_DictionaryType");

                entity.HasComment("编码类型");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Sys_DictionaryType")
                    .IsUnique();

                entity.Property(e => e.Id).HasComment("主键ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("类型描述说明");

                entity.Property(e => e.IsDelete).HasComment("是否删除");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("类型名称");

                entity.Property(e => e.Sort).HasComment("类型顺序");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改人");
            });

            modelBuilder.Entity<SysDistribution>(entity =>
            {
                entity.ToTable("Sys_Distribution");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasComment("分销集团Id");

                entity.Property(e => e.Level).HasComment("层级");

                entity.Property(e => e.ParentReceiveRate).HasComment("上级公司抽成比例");

                entity.Property(e => e.PbranchId)
                    .HasColumnName("PBranchId")
                    .HasComment("父BranchId");

                entity.Property(e => e.TopBranchId).HasComment("第一级BranchId");
            });

            modelBuilder.Entity<SysDistributionGroup>(entity =>
            {
                entity.ToTable("Sys_DistributionGroup");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("分销集团名称");

                entity.Property(e => e.TopBranchId).HasComment("第一级BranchId");
            });

            modelBuilder.Entity<SysErrorLog>(entity =>
            {
                entity.ToTable("Sys_ErrorLog");

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.RelationId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysGroup>(entity =>
            {
                entity.ToTable("Sys_Group");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.IsDistribuionGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysGroupBranch>(entity =>
            {
                entity.ToTable("Sys_GroupBranch");

                entity.HasIndex(e => new { e.BranchId, e.GroupId })
                    .HasName("IX_Sys_GroupBranch")
                    .IsUnique();

                entity.Property(e => e.JoinType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysGroupLoginSetting>(entity =>
            {
                entity.ToTable("Sys_GroupLoginSetting");

                entity.Property(e => e.BodyBgColor)
                    .IsRequired()
                    .HasColumnName("body_bg_color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterBgColor)
                    .IsRequired()
                    .HasColumnName("footer_bg_color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColor)
                    .IsRequired()
                    .HasColumnName("footer_color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterHeight).HasColumnName("footer_height");

                entity.Property(e => e.HeaderBgColor)
                    .IsRequired()
                    .HasColumnName("header_bg_color")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeaderBgImg)
                    .IsRequired()
                    .HasColumnName("header_bg_img")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeaderHeight).HasColumnName("header_height");

                entity.Property(e => e.HeaderLogoImg)
                    .IsRequired()
                    .HasColumnName("header_logo_img")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LoginBgImg)
                    .IsRequired()
                    .HasColumnName("login_bg_img")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginBoxBgColor)
                    .IsRequired()
                    .HasColumnName("login_box_bg_color")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginBoxRadius).HasColumnName("login_box_radius");

                entity.Property(e => e.LoginBoxRight).HasColumnName("login_box_right");

                entity.Property(e => e.LoginBoxTop).HasColumnName("login_box_top");

                entity.Property(e => e.LoginHeight).HasColumnName("login_height");

                entity.Property(e => e.Updatetime)
                    .HasColumnName("updatetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WrapperBgColor)
                    .IsRequired()
                    .HasColumnName("wrapper_bg_color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WrapperBgImg)
                    .IsRequired()
                    .HasColumnName("wrapper_bg_img")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.WrapperMinheight).HasColumnName("wrapper_minheight");

                entity.Property(e => e.WrapperWidth).HasColumnName("wrapper_width");
            });

            modelBuilder.Entity<SysMapiServer>(entity =>
            {
                entity.ToTable("Sys_MapiServer");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AppKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AppSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiresTime).HasColumnType("datetime");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServerUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysPermission>(entity =>
            {
                entity.ToTable("Sys_Permission");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Donvv')")
                    .HasComment("枚举类型ClientType，区分不同的终端");

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupId).HasComment("");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')")
                    .HasComment("图标文件：Iconfont 编码");

                entity.Property(e => e.IsBlank).HasComment("1：允许打开多个新页面（例如：销售开单）；0：只能打开一个页面");

                entity.Property(e => e.IsMenu)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("1:菜单 0：内置权限，例如：销售收款");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Menu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("要显示的菜单名称");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sort)
                    .HasDefaultValueSql("((10))")
                    .HasComment("menu排序");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("");
            });

            modelBuilder.Entity<SysPermissionGroup>(entity =>
            {
                entity.ToTable("Sys_PermissionGroup");

                entity.Property(e => e.ClientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PC')")
                    .HasComment("PC,PDA,APP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sort).HasDefaultValueSql("((10))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysPrice>(entity =>
            {
                entity.ToTable("Sys_Price");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pirce)
                    .HasDefaultValueSql("((1200))")
                    .HasComment("单账号年费用");

                entity.Property(e => e.StartAmount)
                    .HasDefaultValueSql("((5000))")
                    .HasComment("起步售价");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartNum)
                    .HasDefaultValueSql("((5))")
                    .HasComment("起步账号数量");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysPrintSetting>(entity =>
            {
                entity.ToTable("Sys_PrintSetting");

                entity.Property(e => e.OrderHeader)
                    .HasColumnName("Order_Header")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("订单打印的页眉");

                entity.Property(e => e.OrderInstruction)
                    .HasColumnName("Order_Instruction")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("底部说明");

                entity.Property(e => e.OrderLogoUrl)
                    .HasColumnName("Order_LogoUrl")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrintFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysPrintTemplate>(entity =>
            {
                entity.ToTable("Sys_PrintTemplate");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysPrintValidate>(entity =>
            {
                entity.ToTable("Sys_PrintValidate");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiresTime).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysRenew>(entity =>
            {
                entity.ToTable("Sys_Renew");

                entity.Property(e => e.AcountNum)
                    .HasDefaultValueSql("((1))")
                    .HasComment("本次续费账号数量");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnType("date")
                    .HasComment("不包含");

                entity.Property(e => e.Money).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("开通、增加");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.ToTable("Sys_Role");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Sys_Role")
                    .IsUnique();

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysRolePermission>(entity =>
            {
                entity.ToTable("Sys_RolePermission");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysSiteCss>(entity =>
            {
                entity.ToTable("Sys_SiteCSS");

                entity.Property(e => e.CssFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Css,LayOut");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysSms>(entity =>
            {
                entity.ToTable("Sys_Sms");

                entity.HasIndex(e => e.Mobile)
                    .HasName("IX_Sys_Sms");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("短信内容");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("手机号码");

                entity.Property(e => e.Smscode)
                    .HasColumnName("SMSCode")
                    .HasComment(">0 验证码");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysUrlLog>(entity =>
            {
                entity.ToTable("Sys_UrlLog");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysUserRole>(entity =>
            {
                entity.ToTable("Sys_UserRole");

                entity.HasIndex(e => new { e.RoleId, e.UserId })
                    .HasName("IX_Sys_UserRole")
                    .IsUnique();

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysUsers>(entity =>
            {
                entity.ToTable("Sys_Users");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("datetime")
                    .HasComment("生日");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DingId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IsValid).HasComment("1:有效，0：无效");

                entity.Property(e => e.IsYinLi).HasComment("1：阴历生日");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasComment("入职日期");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TokenEndDate)
                    .HasColumnName("tokenEndDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SystemManager>(entity =>
            {
                entity.HasIndex(e => e.LoginName)
                    .HasName("IX_SystemManager")
                    .IsUnique();

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxCategory>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.CategoryShortName).HasMaxLength(500);

                entity.Property(e => e.DescribeInfo)
                    .HasMaxLength(2000)
                    .HasComment("说明");

                entity.Property(e => e.GoodsCategory)
                    .HasMaxLength(1000)
                    .HasComment("货物或劳务类别");

                entity.Property(e => e.IsDefault).HasComment("是否默认");

                entity.Property(e => e.Memo)
                    .HasMaxLength(2000)
                    .HasComment("备注");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate)
                    .HasColumnType("money")
                    .HasComment("增值税率");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaxCategoryGoodsMap>(entity =>
            {
                entity.Property(e => e.GoodsId).HasComment("商品编号");

                entity.Property(e => e.TaxCategoryId).HasComment("税率分类Id");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp");

                entity.Property(e => e.公司名称).HasMaxLength(255);

                entity.Property(e => e.公司编码).HasMaxLength(255);
            });

            modelBuilder.Entity<ThirdCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(500);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(500);

                entity.Property(e => e.SubCategoryName)
                    .HasColumnName("subCategoryName")
                    .HasMaxLength(500);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("updateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ThirdPartyGoodsCategoryMatch>(entity =>
            {
                entity.Property(e => e.BranchId).HasComment("客户Id");

                entity.Property(e => e.LocalGoodsCategoryId).HasComment("本地商品分类编码");

                entity.Property(e => e.LocalGoodsCategoryName)
                    .HasMaxLength(500)
                    .HasComment("本地商品分类名称");

                entity.Property(e => e.ThirdPartyGoodsCategoryId).HasComment("第三方商品分类编码");

                entity.Property(e => e.ThirdPartyGoodsCategoryName)
                    .HasMaxLength(500)
                    .HasComment("第三方商品分类名称");
            });

            modelBuilder.Entity<ThirdPartyGoodsMatch>(entity =>
            {
                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasComment("客户Id");

                entity.Property(e => e.LocalGoodsId).HasComment("本地商品id");

                entity.Property(e => e.LocalGoodsName)
                    .HasMaxLength(500)
                    .HasComment("本地商品名称");

                entity.Property(e => e.ThirdPartyGoodsId).HasComment("第三方商品Id");

                entity.Property(e => e.ThirdPartyGoodsName)
                    .HasMaxLength(500)
                    .HasComment("第三方商品名称");
            });

            modelBuilder.Entity<ThirdPartyLogin>(entity =>
            {
                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUId")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThirdProduct>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddTime)
                    .HasColumnName("addTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FinishTime)
                    .HasColumnName("finishTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasColumnName("goodsId");

                entity.Property(e => e.Introduction).HasColumnName("introduction");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasColumnName("product_code")
                    .HasMaxLength(500);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.InStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.InStoreDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutStoreDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransferArchive>(entity =>
            {
                entity.Property(e => e.PhotoUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferBox>(entity =>
            {
                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferDelivery>(entity =>
            {
                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferDeliveryBox>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferDetail>(entity =>
            {
                entity.HasIndex(e => new { e.GoodsId, e.TransferId })
                    .HasName("IX_TransferDetail")
                    .IsUnique();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SingleRemark).HasMaxLength(500);
            });

            modelBuilder.Entity<TransferLog>(entity =>
            {
                entity.Property(e => e.IsInner).HasComment("1:内部可见；0：客户可见");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("操作");

                entity.Property(e => e.OperatorId).HasComment("操作人Id(Sys_User的Id)");

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("操作人名称(Sys_User的Name)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("调拨单状态");

                entity.Property(e => e.TransferId).HasComment("调拨单号");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferPicking>(entity =>
            {
                entity.Property(e => e.DistributeUserId).HasComment("分单员");

                entity.Property(e => e.PickingUserId).HasComment("理货员Id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferPickingLog>(entity =>
            {
                entity.Property(e => e.GoodsId).HasComment("商品Id");

                entity.Property(e => e.Num).HasComment("拣货数量");

                entity.Property(e => e.PickingUserId).HasComment("拣货员Id");

                entity.Property(e => e.StoreId).HasComment("调出仓库Id");

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength()
                    .HasComment("库位");

                entity.Property(e => e.TransferDetailId).HasComment("调拨单明细ID");

                entity.Property(e => e.TransferId).HasComment("调拨单号");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TransferReceiveMoney>(entity =>
            {
                entity.Property(e => e.ChargeOff)
                    .HasColumnType("money")
                    .HasComment("销账金额");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("付款方式");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney)
                    .HasColumnType("money")
                    .HasComment("收款金额");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransferStatement>(entity =>
            {
                entity.Property(e => e.BranchId).HasComment("调入公司BranchId");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasComment("操作员");
            });

            modelBuilder.Entity<VDeadLockProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DeadLock_Process");

                entity.Property(e => e.Blocked).HasColumnName("blocked");

                entity.Property(e => e.Cmd)
                    .IsRequired()
                    .HasColumnName("cmd")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.ContextInfo)
                    .IsRequired()
                    .HasColumnName("context_info")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Cpu).HasColumnName("cpu");

                entity.Property(e => e.Dbid).HasColumnName("dbid");

                entity.Property(e => e.Ecid).HasColumnName("ecid");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasColumnName("hostname")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Hostprocess)
                    .IsRequired()
                    .HasColumnName("hostprocess")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Kpid).HasColumnName("kpid");

                entity.Property(e => e.LastBatch)
                    .HasColumnName("last_batch")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastwaittype)
                    .IsRequired()
                    .HasColumnName("lastwaittype")
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.LoginTime)
                    .HasColumnName("login_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Loginame)
                    .IsRequired()
                    .HasColumnName("loginame")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Memusage).HasColumnName("memusage");

                entity.Property(e => e.NetAddress)
                    .IsRequired()
                    .HasColumnName("net_address")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NetLibrary)
                    .IsRequired()
                    .HasColumnName("net_library")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NtDomain)
                    .IsRequired()
                    .HasColumnName("nt_domain")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.NtUsername)
                    .IsRequired()
                    .HasColumnName("nt_username")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.OpenTran).HasColumnName("open_tran");

                entity.Property(e => e.PhysicalIo).HasColumnName("physical_io");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasColumnName("program_name")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("sid")
                    .HasMaxLength(86)
                    .IsFixedLength();

                entity.Property(e => e.Spid).HasColumnName("spid");

                entity.Property(e => e.SqlHandle)
                    .IsRequired()
                    .HasColumnName("sql_handle")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.StmtEnd).HasColumnName("stmt_end");

                entity.Property(e => e.StmtStart).HasColumnName("stmt_start");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Waitresource)
                    .IsRequired()
                    .HasColumnName("waitresource")
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.Property(e => e.Waittime).HasColumnName("waittime");

                entity.Property(e => e.Waittype)
                    .IsRequired()
                    .HasColumnName("waittype")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Customer");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeesNum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoicePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Py)
                    .HasColumnName("PY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatementMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCustomerCounterDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CustomerCounterDetail");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Vipprice)
                    .HasColumnName("VIPPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ViewCustomerLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CustomerLog");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCustomerPreReceiveMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CustomerPreReceiveMoney");

                entity.Property(e => e.ActualPayTime).HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InitialBalance).HasColumnType("money");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreReceiveMoney).HasColumnType("money");

                entity.Property(e => e.ReceiveAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewDeliverAchievement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DeliverAchievement");

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PickTime).HasColumnType("datetime");

                entity.Property(e => e.PickUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDeliveryLineCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DeliveryLineCustomer");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LineRange).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewDeliveryLineMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DeliveryLineMember");

                entity.Property(e => e.LineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewDistributionCustomerInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionCustomerInvoice");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionCustomerInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionCustomerInvoiceDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionCustomerReceiveMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionCustomerReceiveMoney");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionCustomerReceiveMoneyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionCustomerReceiveMoneyDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionInvoice");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PbranchName)
                    .IsRequired()
                    .HasColumnName("PBranchName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionInvoiceDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PbranchName)
                    .IsRequired()
                    .HasColumnName("PBranchName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionPay");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChildBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionPayDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionPayDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.ChildBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionReceiveInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionReceiveInvoice");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChildBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionReceiveInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionReceiveInvoiceDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.ChildBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionReceiveMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionReceiveMoney");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PbranchName)
                    .IsRequired()
                    .HasColumnName("PBranchName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDistributionReceiveMoneyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DistributionReceiveMoneyDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PbranchName)
                    .IsRequired()
                    .HasColumnName("PBranchName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDostatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DOStatement");

                entity.Property(e => e.ApplyInvoiceMoney).HasColumnType("money");

                entity.Property(e => e.ApplyReceiveMoney).HasColumnType("money");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Customer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceChargeOff).HasColumnType("money");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SumGoodsAmount).HasColumnType("money");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewDpstatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DPStatement");

                entity.HasComment("分销对账付款视图");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.InvoiceApplyMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceChargeOff).HasColumnType("money");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaidApplyMoney).HasColumnType("money");

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.UpdateByName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewGoods>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Goods");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CombinationType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuxiao)
                    .HasColumnName("cuxiao")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CuxiaoDate)
                    .HasColumnName("cuxiaoDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSku).HasColumnName("DonvvSKU");

                entity.Property(e => e.Feature)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FranchiseeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PackingList)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrivateTypeName).HasMaxLength(50);

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasColumnName("PY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecommendDate).HasColumnType("datetime");

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tpn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tpname)
                    .HasColumnName("TPName")
                    .HasMaxLength(500);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ViewGoodsDefaultInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Goods_DefaultInfo");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AddUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CombinationType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuxiao)
                    .HasColumnName("cuxiao")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CuxiaoDate)
                    .HasColumnName("cuxiaoDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSku).HasColumnName("DonvvSKU");

                entity.Property(e => e.Feature)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GdiaddTime)
                    .HasColumnName("GDIAddTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gdiid).HasColumnName("GDIId");

                entity.Property(e => e.GdiupdateTime)
                    .HasColumnName("GDIUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PackingList)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Py)
                    .IsRequired()
                    .HasColumnName("PY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecommendDate).HasColumnType("datetime");

                entity.Property(e => e.SalesAnalysis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ViewGoodsModelValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GoodsModelValue");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewGoodsPackage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GoodsPackage");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CombinationType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSkuCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSpuCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewGoodsParamValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GoodsParamValue");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewGoodsPhoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GoodsPhoto");

                entity.Property(e => e.Photo100Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Photo250Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewGoodsTypeParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GoodsTypeParam");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewGroupOrderStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GroupOrderStatement");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewGroupPay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GroupPay");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewIbeiJingGoodsMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_IBeiJingGoodsMap");

                entity.Property(e => e.Expr1).HasMaxLength(255);

                entity.Property(e => e.IBrand)
                    .HasColumnName("I_Brand")
                    .HasMaxLength(255);

                entity.Property(e => e.ICategory)
                    .HasColumnName("I_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.IProductId)
                    .HasColumnName("I_ProductId")
                    .HasMaxLength(255);

                entity.Property(e => e.IProductName)
                    .HasColumnName("I_ProductName")
                    .HasMaxLength(500);

                entity.Property(e => e.ISalePrice)
                    .HasColumnName("I_SalePrice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewIcategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ICategory");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Discount2).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Discount3).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Discount4).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ICategory)
                    .IsRequired()
                    .HasColumnName("I_Category")
                    .HasMaxLength(100);

                entity.Property(e => e.IPlatId).HasColumnName("I_PlatId");

                entity.Property(e => e.ITypeCode)
                    .IsRequired()
                    .HasColumnName("I_TypeCode")
                    .HasMaxLength(100);

                entity.Property(e => e.ITypeName)
                    .IsRequired()
                    .HasColumnName("I_TypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewIgoods>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_IGoods");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IProjectId).HasColumnName("I_ProjectId");

                entity.Property(e => e.MarketPrice).HasColumnType("money");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ViewInventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Inventory");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Afc)
                    .HasColumnName("AFC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZoneMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewInventoryLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InventoryLog");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("money");

                entity.Property(e => e.Afc)
                    .HasColumnName("AFC")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldStoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewInventoryModifyAc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InventoryModifyAC");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyAcid).HasColumnName("ModifyACId");

                entity.Property(e => e.NewAc)
                    .HasColumnName("NewAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldAc)
                    .HasColumnName("OldAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZoneMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Invoice");

                entity.Property(e => e.AllInvoiceMoney).HasColumnType("money");

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDetailUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRequireUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdfUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlatInvoiceRequestNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCost).HasColumnType("money");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatementUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewInvoiceAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceAudit");

                entity.Property(e => e.ApplyInvoiceTime)
                    .HasColumnName("applyInvoiceTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NeedToInvoice).HasColumnType("money");

                entity.Property(e => e.RealInvoiceMoney)
                    .HasColumnName("realInvoiceMoney")
                    .HasColumnType("money");

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatementName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewInvoiceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceLog");

                entity.Property(e => e.AllInvoiceMoney).HasColumnType("money");

                entity.Property(e => e.CancelDetailUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CancelOrderNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CancelPdfUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CancelPlatInvoiceRequestNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceCreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceCreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDeleteTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDeleteUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceRequireUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PdfUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlatInvoiceRequestNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatementIds)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatementUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");
            });

            modelBuilder.Entity<ViewInvoiceRequire>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceRequire");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NeedToInvoice).HasColumnType("money");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatementName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumGoodsAmount).HasColumnType("money");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewInvoiceRequireDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceRequireDetail");

                entity.Property(e => e.BuyerAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceContent).IsRequired();

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odnum).HasColumnName("ODNum");

                entity.Property(e => e.OdpickNum).HasColumnName("ODPickNum");

                entity.Property(e => e.SaleAddress)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBank)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaleBankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTaxNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewIorderContract>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_IOrderContract");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.Caddress)
                    .HasColumnName("CAddress")
                    .HasMaxLength(1000);

                entity.Property(e => e.Cfax)
                    .HasColumnName("CFax")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNum).HasMaxLength(100);

                entity.Property(e => e.ConNum).HasMaxLength(50);

                entity.Property(e => e.ContractName).HasMaxLength(100);

                entity.Property(e => e.ContractNum)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ctel)
                    .HasColumnName("CTel")
                    .HasMaxLength(100);

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveUser).HasMaxLength(50);

                entity.Property(e => e.Sign).HasColumnType("text");

                entity.Property(e => e.Signature).HasColumnType("text");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewIprojectPlat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_IProjectPlat");

                entity.Property(e => e.AccessToken).HasMaxLength(100);

                entity.Property(e => e.AppKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AppSecret)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.IPlatId).HasColumnName("I_PlatId");

                entity.Property(e => e.IProviderId).HasColumnName("I_ProviderId");

                entity.Property(e => e.PlatMemo).HasMaxLength(50);

                entity.Property(e => e.PlatName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrivateKey)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderMemo).HasMaxLength(50);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewLogisticsCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LogisticsCompany");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticsCompany).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Member");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.RegisterMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VipcounterLevel).HasColumnName("VIPCounterLevel");
            });

            modelBuilder.Entity<ViewMemberAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MemberAddress");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Area).HasMaxLength(20);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(20);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewMemberCart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MemberCart");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewMemberDeliveryLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MemberDeliveryLine");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewMemberOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Member_Orders");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IName)
                    .HasColumnName("I_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent).HasMaxLength(4000);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount).HasColumnType("money");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFinishTime).HasColumnType("datetime");

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewModifyAc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ModifyAC");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(1000);

                entity.Property(e => e.ModifyInventoryAc).HasColumnName("ModifyInventoryAC");

                entity.Property(e => e.ModifyOrderDetailAc).HasColumnName("ModifyOrderDetailAC");

                entity.Property(e => e.NewAc)
                    .HasColumnName("NewAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NewInPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldAc)
                    .HasColumnName("OldAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldInPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewNeedToPurchaseDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_NeedToPurchaseDetail");

                entity.Property(e => e.CreditCard)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsMemo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewNews>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_News");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewOrderAfterSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderAfterSale");

                entity.Property(e => e.ApplyReason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.ApplyType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactWay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InnerStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperateMessage).HasMaxLength(500);

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickupAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionDescribe)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiveAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnWay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updatetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewOrderDeliveryBox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDeliveryBox");

                entity.Property(e => e.OrderBoxStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDeliveryStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDetail");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("money");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Afc)
                    .HasColumnName("AFC")
                    .HasColumnType("money");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailGrossProfit).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNoTaxPrice).HasColumnType("money");

                entity.Property(e => e.DisplayPrice).HasColumnType("money");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.GrossProfitPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxAmount).HasColumnType("money");

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.NoTaxPrice).HasColumnType("money");

                entity.Property(e => e.OrderAmount).HasColumnType("money");

                entity.Property(e => e.OrderGrossProfitPercent).HasColumnType("money");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFinishTime).HasColumnType("datetime");

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tpn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewOrderDetailGoods>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDetail_Goods");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("money");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayPrice).HasColumnType("money");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.GrossProfitPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PurchaseMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDistribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDistribution");

                entity.HasComment("分销订单明细");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AllocationTime).HasColumnType("datetime");

                entity.Property(e => e.ArchivedTime).HasColumnType("datetime");

                entity.Property(e => e.ArriveTime).HasColumnType("datetime");

                entity.Property(e => e.AuditRemark).HasMaxLength(300);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.ChargeOff).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConfirmFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Freight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.GrossProfitPercent).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IName)
                    .HasColumnName("I_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent).HasMaxLength(4000);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.OrderAmount).HasColumnType("money");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayAmount).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PickTime).HasColumnType("datetime");

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFinishTime).HasColumnType("datetime");

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Usercode)
                    .HasColumnName("usercode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderDistributionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDistributionDetail");

                entity.HasComment("分销订单明细");

                entity.Property(e => e.AllocationTime).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ArriveTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayPrice).HasColumnType("money");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.GrossProfitPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgAmount).HasColumnType("money");

                entity.Property(e => e.OrgPrice).HasColumnType("money");

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PickTime).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderGoodsComments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderGoodsComments");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewOrderModify>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderModify");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewPrice).HasColumnType("money");

                entity.Property(e => e.NewTaxRate).HasColumnType("money");

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.OldTaxRate).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderModifyAc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderModifyAC");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.ModifyAcid).HasColumnName("ModifyACId");

                entity.Property(e => e.NewAc)
                    .HasColumnName("NewAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NewGrossProfit).HasColumnType("money");

                entity.Property(e => e.NewGrossProfitPercent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldAc)
                    .HasColumnName("OldAC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldGrossProfitPercent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewOrderPicking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderPicking");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount).HasColumnType("money");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderReceiveMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderReceiveMoney");

                entity.Property(e => e.Bankinfo)
                    .HasColumnName("bankinfo")
                    .HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountMoney).HasColumnType("money");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderReceiveMoneyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderReceiveMoneyDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Odnum).HasColumnName("ODNum");

                entity.Property(e => e.OdpickNum).HasColumnName("ODPickNum");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReceiveAccount).HasMaxLength(300);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrderStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderStatement");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceContent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NeedToInvoice).HasColumnType("money");

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SumGoodsAmount).HasColumnType("money");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Orders");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ArchiveUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedTime).HasColumnType("datetime");

                entity.Property(e => e.AuditRemark).HasMaxLength(300);

                entity.Property(e => e.ChargeOff).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConfirmFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Freight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.GrossProfitPercent).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IName)
                    .HasColumnName("I_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent).HasMaxLength(4000);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.OrderAmount).HasColumnType("money");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesIdNow).HasColumnName("SalesId_Now");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesNameNow)
                    .HasColumnName("SalesName_Now")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFinishTime).HasColumnType("datetime");

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrdersYangCaiLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrdersYangCaiLog");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AuditRemark).HasMaxLength(300);

                entity.Property(e => e.ChargeOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConfirmFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryFinishTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IName)
                    .HasColumnName("I_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.PrintTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiptCode).HasMaxLength(100);

                entity.Property(e => e.ServiceFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFinishTime).HasColumnType("datetime");

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Usercode)
                    .HasColumnName("usercode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOrmaudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ORMAudit");

                entity.Property(e => e.ApproveUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankinfo)
                    .HasColumnName("bankinfo")
                    .HasMaxLength(302);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountMoney).HasColumnType("money");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPickOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PickOrderDetail");

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasColumnType("money");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PurchaseMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZoneMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPickPurchaseDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PickPurchaseDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DelayDate).HasColumnType("date");

                entity.Property(e => e.DetailMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IIsCustomGoods).HasColumnName("I_IsCustomGoods");

                entity.Property(e => e.IOrderDetailId).HasColumnName("I_OrderDetailId");

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZoneMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewProductInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Product_Info");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSku).HasColumnName("DonvvSKU");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SourceUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Purchase");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AddUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.EstimateRecieveDate).HasColumnType("datetime");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.OpeningBank).HasMaxLength(500);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PutInStoreTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierTaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchaseDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseDetail");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AddUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BillsPrice).HasColumnType("money");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.DelayDate).HasColumnType("date");

                entity.Property(e => e.DetailMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvBrandId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvBrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSku).HasColumnName("DonvvSKU");

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxAmount).HasColumnType("money");

                entity.Property(e => e.NoTaxInPrice).HasColumnType("money");

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PutInStoreTime).HasColumnType("datetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchaseLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseLog");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PurchaseStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchaseModify>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseModify");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.NewNoTaxPrice).HasColumnType("money");

                entity.Property(e => e.NewPrice).HasColumnType("money");

                entity.Property(e => e.NewTaxRate).HasColumnType("money");

                entity.Property(e => e.OldNoTaxPrice).HasColumnType("money");

                entity.Property(e => e.OldPrice).HasColumnType("money");

                entity.Property(e => e.OldTaxRate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchasePay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchasePay");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayAccount).HasMaxLength(300);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchasePayAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchasePayAudit");

                entity.Property(e => e.ApproveUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.FinanceData).HasColumnType("text");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchasePayDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchasePayDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.ChargeOffAmount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayAccount).HasMaxLength(300);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayMoney).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchaseQuoteDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseQuoteDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvSku).HasColumnName("DonvvSKU");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewPurchaseStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseStatement");

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Expr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchaseStatementDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseStatementDetail");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewPurchaseStatementGoodsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PurchaseStatementGoodsDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DelayDate).HasColumnType("date");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoTaxAmount).HasColumnType("money");

                entity.Property(e => e.NoTaxInPrice).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewQuotationOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_QuotationOrder");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConfirmFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ConfirmStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfit).HasColumnType("money");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IName)
                    .HasColumnName("I_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IOrderId)
                    .HasColumnName("I_OrderId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.Property(e => e.PlanDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("money");

                entity.Property(e => e.PurchaseFinishTime).HasColumnType("datetime");

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationStatus).HasMaxLength(50);

                entity.Property(e => e.QuotationTime).HasColumnType("datetime");

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSourceGoods>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SourceGoods");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CombinationType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sn)
                    .IsRequired()
                    .HasColumnName("SN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceBrand)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCategory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceMainSku)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourcePrice).HasColumnType("money");

                entity.Property(e => e.SourceSku)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpecVals)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSupplierDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierDetail");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BillsPrice).HasColumnType("money");

                entity.Property(e => e.DelayDate).HasColumnType("date");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSupplierInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierInvoice");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceMoney).HasColumnType("money");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SysUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSupplierInvoiceDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierInvoiceDetails");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InPrice).HasColumnType("money");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PutInStoreTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToInvoiceMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSupplierOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierOrder");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.SupplierStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSupplierPrepayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierPrepayment");

                entity.Property(e => e.ActualPayTime).HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BankInfo).HasMaxLength(302);

                entity.Property(e => e.InitialBalance).HasColumnType("money");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Operate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payment).HasColumnType("money");

                entity.Property(e => e.Prepayment).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSupplierReceiveInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierReceiveInvoice");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.LastTimeSabalance)
                    .HasColumnName("LastTimeSABalance")
                    .HasColumnType("money");

                entity.Property(e => e.LastTimeSadate)
                    .HasColumnName("LastTimeSADate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseAmount).HasColumnType("money");

                entity.Property(e => e.PurchasePayAmount).HasColumnType("money");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSupplierSettleAccounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierSettleAccounts");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.LastTimeBalance).HasColumnType("money");

                entity.Property(e => e.LastTimeSadate)
                    .HasColumnName("LastTimeSADate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PurchaseAmount).HasColumnType("money");

                entity.Property(e => e.PurchasePayAmount).HasColumnType("money");

                entity.Property(e => e.SettleAccountDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SysUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSysBranchCss>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sys_Branch_CSS");

                entity.Property(e => e.CssFileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSysBranchGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sys_BranchGroup");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityAlias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Domain2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvDomain)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.GroupExpiredDate).HasColumnType("date");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Introduction).HasColumnType("text");

                entity.Property(e => e.JoinType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSysDistribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sys_Distribution");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchAddTime).HasColumnType("datetime");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchShortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityAlias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Domain2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DonvvDomain)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Introduction).HasColumnType("text");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.PbranchId).HasColumnName("PBranchId");

                entity.Property(e => e.PbranchName)
                    .HasColumnName("PBranchName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSysPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sys_Permission");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Menu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSysRolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sys_RolePermission");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Menu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSysUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sys_Users");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DingId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TokenEndDate)
                    .HasColumnName("tokenEndDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTaxCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TaxCategory");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AddUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescribeInfo).HasMaxLength(2000);

                entity.Property(e => e.GoodsCategory).HasMaxLength(1000);

                entity.Property(e => e.GoodsTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(2000);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRate).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Transfer");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.InBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.InStoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OutStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutStoreDate).HasColumnType("datetime");

                entity.Property(e => e.OutStoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutStoreUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTransferDeliveryBox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TransferDeliveryBox");

                entity.Property(e => e.TransferBoxStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferDeliveryStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTransferDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TransferDetail");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutStoreDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleRemark).HasMaxLength(500);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewTransferPicking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TransferPicking");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.InBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreDate).HasColumnType("datetime");

                entity.Property(e => e.InStoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InStoreUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutBranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OutStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutStoreDate).HasColumnType("datetime");

                entity.Property(e => e.OutStoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickingUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTransferReceiveMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TransferReceiveMoney");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTransferStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TransferStatement");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeOff).HasColumnType("money");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaidMoney).HasColumnType("money");

                entity.Property(e => e.PayStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewUserPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_User_Permission");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Menu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_User_Role");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVipapply>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VIPApply");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceContent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType).HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewVipapplyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VIPApplyDetail");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayPrice).HasColumnType("money");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MemberDeptCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberDeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberDeptPcode)
                    .HasColumnName("MemberDeptPCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVipcounterCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VIPCounterCustomer");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewVipcounterDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VIPCounterDetail");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HomeImage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("PCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vipprice)
                    .HasColumnName("VIPPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ViewVirtualInventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VirtualInventory");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vipapply>(entity =>
            {
                entity.ToTable("VIPApply");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.EmailForInvoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('纸质发票')");

                entity.Property(e => e.InvoiceContent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayType).HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SumMoney).HasColumnType("money");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VipapplyDetail>(entity =>
            {
                entity.ToTable("VIPApplyDetail");

                entity.HasIndex(e => new { e.ApplyId, e.GoodsId })
                    .HasName("IX_VIPApplyDetail")
                    .IsUnique();

                entity.Property(e => e.DisplayPrice).HasColumnType("money");

                entity.Property(e => e.DisplayUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<VipapplyInvoiceInfo>(entity =>
            {
                entity.ToTable("VIPApplyInvoiceInfo");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("购方地址");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("购方开户行");

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("购方开户行账号");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方发票内容");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方电子邮箱");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("发票备注");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方手机号");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("购方发票抬头");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方注册电话");

                entity.Property(e => e.TaxNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("购方税号");

                entity.Property(e => e.Type).HasComment("发票类型");
            });

            modelBuilder.Entity<VipapplyLog>(entity =>
            {
                entity.ToTable("VIPApplyLog");

                entity.Property(e => e.Id).HasComment("Id，主键");

                entity.Property(e => e.ApplyId).HasComment("申请单Id");

                entity.Property(e => e.ApplyUserId).HasComment("申请人Id(MemberId)");

                entity.Property(e => e.Memo)
                    .HasMaxLength(500)
                    .HasComment("备注");

                entity.Property(e => e.OperateStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("操作状态（待审核，已审核，已驳回）");

                entity.Property(e => e.OperatorId).HasComment("操作人Id(MemberId)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VipapplyModify>(entity =>
            {
                entity.ToTable("VIPApplyModify");

                entity.HasIndex(e => e.ApplyId)
                    .HasName("IX_VIPApplyModify");

                entity.Property(e => e.OperaterId).HasComment("修改人的MemberId");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Vipcounter>(entity =>
            {
                entity.ToTable("VIPCounter");

                entity.HasIndex(e => new { e.BranchId, e.Name })
                    .HasName("IX_VIPCounter")
                    .IsUnique();

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VipcounterCustomer>(entity =>
            {
                entity.ToTable("VIPCounterCustomer");

                entity.HasIndex(e => new { e.CounterId, e.CustomerId })
                    .HasName("IX_VIPCounterCustomer")
                    .IsUnique();

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VipcounterDetail>(entity =>
            {
                entity.ToTable("VIPCounterDetail");

                entity.HasIndex(e => new { e.CounterId, e.GoodsId })
                    .HasName("IX_VIPCounterDetail")
                    .IsUnique();

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsSales)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否在售");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.Vipprice)
                    .HasColumnName("VIPPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VirtualInventory>(entity =>
            {
                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<YangCaiOrderLog>(entity =>
            {
                entity.Property(e => e.LogText).HasMaxLength(4000);

                entity.Property(e => e.ReceiptAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReceiptCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

      
    }
}
