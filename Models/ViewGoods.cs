using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewGoods
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
        public int FranchiseeId { get; set; }
        public string FranchiseeName { get; set; }
        public decimal Price { get; set; }
        public decimal InPrice { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string PackingList { get; set; }
        public string Service { get; set; }
        public int Recommend { get; set; }
        public DateTime RecommendDate { get; set; }
        public decimal Cuxiao { get; set; }
        public DateTime CuxiaoDate { get; set; }
        public int Rate { get; set; }
        public string HomeImage { get; set; }
        public bool IsEnable { get; set; }
        public bool IsWeb { get; set; }
        public string CombinationType { get; set; }
        public int ParentId { get; set; }
        public int SaleNumber { get; set; }
        public int SaleCount { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string TypeName { get; set; }
        public string PrivateTypeName { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public int Level { get; set; }
        public int StockNum { get; set; }
        public int PointRate { get; set; }
        public int UserId { get; set; }
        public string Feature { get; set; }
        public int MinimumQuantity { get; set; }
        public string UserName { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string InnerId { get; set; }
        public decimal Weight { get; set; }
        public string BrandName { get; set; }
        public string FullName { get; set; }
        public int PhotoNum { get; set; }
        public int DetailPhotoNum { get; set; }
        public string Model { get; set; }
        public bool IsPublic { get; set; }
        public int DonvvSku { get; set; }
        public bool ForbidWebOrderByNoStock { get; set; }
        public string Color { get; set; }
        public string Tpn { get; set; }
        public string Tpname { get; set; }
        public string TaxCode { get; set; }
        public int? DataSource { get; set; }
        public string Tags { get; set; }
        public bool GoodsTypeDisable { get; set; }
    }
}
