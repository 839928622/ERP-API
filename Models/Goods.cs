using System;

namespace ERP_API.Models
{
    public partial class Goods
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public int BranchId { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public string Sn { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Py { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal InPrice { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public string PackingList { get; set; }
        public string Service { get; set; }
        public int Recommend { get; set; }
        public DateTime RecommendDate { get; set; }
        public decimal Cuxiao { get; set; }
        public DateTime CuxiaoDate { get; set; }
        public int Rate { get; set; }
        public string HomeImage { get; set; }
        public bool? IsEnable { get; set; }
        public bool? IsWeb { get; set; }
        public string CombinationType { get; set; }
        public int ParentId { get; set; }
        public int SaleNumber { get; set; }
        public int SaleCount { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int StockNum { get; set; }
        public string Feature { get; set; }
        public int UserId { get; set; }
        public string InnerId { get; set; }
        public int PhotoNum { get; set; }
        public int DetailPhotoNum { get; set; }
        public string Model { get; set; }
        public bool IsPublic { get; set; }
        public int DonvvSku { get; set; }
        public int MinimumQuantity { get; set; }
        public string SalesAnalysis { get; set; }
        public bool ForbidWebOrderByNoStock { get; set; }
        public decimal? PriceExtend { get; set; }
        public string Color { get; set; }
        public int FranchiseeId { get; set; }
        public string Tpn { get; set; }
        public string Tpname { get; set; }
        public string TaxCode { get; set; }
        public int? DataSource { get; set; }
        public string Tags { get; set; }
    }
}
