using System;

namespace ERP_API.Models
{
    public partial class Quotation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime QuotationTime { get; set; }
        public DateTime ValidTime { get; set; }
        public int OrderId { get; set; }
        public int ValidDay { get; set; }
        public bool IsDelete { get; set; }
        public int BranchId { get; set; }
    }
}
