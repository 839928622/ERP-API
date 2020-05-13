using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class FinanceRecord
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int BankId { get; set; }
        public string BankInfo { get; set; }
        public decimal InitBalance { get; set; }
        public decimal OperateAmount { get; set; }
        public decimal Balance { get; set; }
        public string Operate { get; set; }
        public string PayType { get; set; }
        public int DebtorId { get; set; }
        public int LenderId { get; set; }
        public string DebtorName { get; set; }
        public string LenderName { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Tpn { get; set; }
        public string Remark { get; set; }
        public DateTime? OpreteDate { get; set; }
        public DateTime? AddAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
