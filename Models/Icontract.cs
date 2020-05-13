using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class Icontract
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string ContractName { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string ConNum { get; set; }
        public string Signature { get; set; }
        public string Sign { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public string Tel { get; set; }
        public string CompanyNum { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
