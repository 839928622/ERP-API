﻿using System;

namespace ERP_API.Models
{
    public partial class PurchaseStatement
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public decimal SumMoney { get; set; }
        public decimal PaidMoney { get; set; }
        public string PayStatus { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal ChargeOff { get; set; }
    }
}
