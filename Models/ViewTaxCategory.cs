using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewTaxCategory
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxCode { get; set; }
        public string GoodsCategory { get; set; }
        public string DescribeInfo { get; set; }
        public string Memo { get; set; }
        public bool IsDefault { get; set; }
        public int AddUserId { get; set; }
        public DateTime AddTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string AddUserName { get; set; }
        public string UpdateUserName { get; set; }
        public string GoodsTypeName { get; set; }
    }
}
