using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewSupplierReceiveInvoice
    {
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public DateTime? LastTimeSadate { get; set; }
        public decimal LastTimeSabalance { get; set; }
        public decimal? PurchaseAmount { get; set; }
        public decimal? PurchasePayAmount { get; set; }
        public decimal? InvoiceAmount { get; set; }
    }
}
