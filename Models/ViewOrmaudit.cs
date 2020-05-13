using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrmaudit
    {
        public int Id { get; set; }
        public int OrderStatementId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal ReceiveMoney { get; set; }
        public decimal DiscountMoney { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string PayType { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ShortName { get; set; }
        public int SalesId { get; set; }
        public int ServiceId { get; set; }
        public string UserName { get; set; }
        public string Telphone { get; set; }
        public decimal SumMoney { get; set; }
        public string PayStatus { get; set; }
        public decimal PaidMoney { get; set; }
        public int? BankInfoId { get; set; }
        public int BranchId { get; set; }
        public string Bankinfo { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string ApproveUser { get; set; }
    }
}
