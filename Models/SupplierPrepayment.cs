using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SupplierPrepayment
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int PurchaseStatementId { get; set; }
        public decimal InitialBalance { get; set; }
        public string Operate { get; set; }
        public decimal Prepayment { get; set; }
        public decimal Payment { get; set; }
        public decimal Balance { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PayType { get; set; }
        public string PayAccount { get; set; }
        public DateTime ActualPayTime { get; set; }
    }
}
