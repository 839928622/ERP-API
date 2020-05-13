using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PurchaseQuote
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int PurchaseId { get; set; }
        public string DonvvBrandId { get; set; }
        public string DonvvBrandName { get; set; }
        public string DonvvSupplierId { get; set; }
        public string DonvvSupplierName { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
