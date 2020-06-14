using System;

namespace ERP_API.Models
{
    public partial class EmailInvoiceSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string PlatIdentity { get; set; }
        public string SaleName { get; set; }
        public string SaleBank { get; set; }
        public string SaleBankAccount { get; set; }
        public string SaleTaxNum { get; set; }
        public string SalePhone { get; set; }
        public string SaleAddress { get; set; }
        public string PlatApi { get; set; }
        public bool IsEnable { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string Token { get; set; }
        public long? ExpiresTime { get; set; }
        public int? Plat { get; set; }
    }
}
