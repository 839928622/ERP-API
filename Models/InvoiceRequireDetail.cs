using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class InvoiceRequireDetail
    {
        public int Id { get; set; }
        public int InvoiceRequireId { get; set; }
        public int OrderDetailId { get; set; }
        public int GoodsInvoiceNum { get; set; }
        public int? StatementId { get; set; }
        public int? OrderId { get; set; }
        public decimal? InvoiceMoney { get; set; }
        public decimal? TaxRate { get; set; }
        public string TaxCode { get; set; }
        public string DisplayName { get; set; }
        public int GoodsId { get; set; }
    }
}
