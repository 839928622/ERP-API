using System;

namespace ERP_API.Models
{
    public partial class ICategory : BaseEntity
    {
      
        public int IPlatId { get; set; }
        public string ITypeCode { get; set; }
        public string ITypeName { get; set; }
        public string ICategory1 { get; set; }
        public int TypeId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal Discount { get; set; }
        public decimal? Discount2 { get; set; }
        public decimal? Discount3 { get; set; }
        public decimal? Discount4 { get; set; }
    }
}
