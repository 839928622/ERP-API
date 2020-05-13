using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class CustomerPreReceiveMoney
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int OrderStatementId { get; set; }
        public decimal InitialBalance { get; set; }
        public string Operate { get; set; }
        public decimal PreReceiveMoney { get; set; }
        public decimal ReceiveMoney { get; set; }
        public decimal Balance { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PayType { get; set; }
        public string ReceiveAccount { get; set; }
        public DateTime ActualPayTime { get; set; }
    }
}
