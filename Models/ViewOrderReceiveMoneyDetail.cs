using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderReceiveMoneyDetail
    {
        public int Id { get; set; }
        public int ReceiveMoneyId { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal ChargeOffAmount { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
        public string GoodsName { get; set; }
        public string Unit { get; set; }
        public int OrderStatementId { get; set; }
        public decimal ChargeOff { get; set; }
        public decimal ReceiveMoney { get; set; }
        public string PayType { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public int? ReceiveAccountId { get; set; }
        public int Odnum { get; set; }
        public int OdpickNum { get; set; }
        public string ReceiveAccount { get; set; }
        public int BranchId { get; set; }
    }
}
