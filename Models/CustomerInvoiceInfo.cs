using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class CustomerInvoiceInfo
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoicePhone { get; set; }
        public string InvoiceBank { get; set; }
        public string InvoiceAccount { get; set; }
        public string InvoiceMemo { get; set; }
        public string MemberName { get; set; }
    }
}
