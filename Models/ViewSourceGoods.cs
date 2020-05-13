using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewSourceGoods
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SourceId { get; set; }
        public string Url { get; set; }
        public string SourceSku { get; set; }
        public string SourceMainSku { get; set; }
        public string SpecVals { get; set; }
        public string SourceCategory { get; set; }
        public string SourceBrand { get; set; }
        public decimal SourcePrice { get; set; }
        public int TargetParentId { get; set; }
        public int TargetGoodsId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DisplayName { get; set; }
        public string Sn { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int PhotoNum { get; set; }
        public int DetailPhotoNum { get; set; }
        public bool IsEnable { get; set; }
        public string CombinationType { get; set; }
        public string Model { get; set; }
    }
}
