using System;

namespace ERP_API.Models
{
    public partial class SysBranchBankInfo
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDefault { get; set; }
        public decimal? Balance { get; set; }
        public bool? IsEnable { get; set; }
    }
}
