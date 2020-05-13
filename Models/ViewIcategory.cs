using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewIcategory
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int IPlatId { get; set; }
        public string ITypeCode { get; set; }
        public string ITypeName { get; set; }
        public string ICategory { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal Discount { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public decimal? Discount2 { get; set; }
        public decimal? Discount3 { get; set; }
        public decimal? Discount4 { get; set; }
    }
}
