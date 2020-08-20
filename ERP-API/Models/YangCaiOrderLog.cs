using System;

namespace ERP_API.Models
{
    public partial class YangCaiOrderLog
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string UserCode { get; set; }
        public string LogText { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string ReceiptCode { get; set; }
        public decimal ReceiptAmount { get; set; }
    }
}
