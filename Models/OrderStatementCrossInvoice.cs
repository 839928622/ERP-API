using System;

namespace ERP_API.Models
{
    public partial class OrderStatementCrossInvoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StatementId { get; set; }
        public int InvoiceRequireId { get; set; }
        public bool IsDetele { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
