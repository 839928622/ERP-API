using System;

namespace ERP_API.Models
{
    public partial class DistributionCustomerReceiveMoney : BaseEntity
    {
      
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Operate { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal ReceiveMoney { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string PayType { get; set; }
        public int? ReceiveAccount { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
        public int StatementId { get; set; }
    }
}
