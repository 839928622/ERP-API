using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewIorderContract
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ContractId { get; set; }
        public string ContractNum { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string ReceiveUser { get; set; }
        public int? BranchId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Fax { get; set; }
        public string Tel { get; set; }
        public string ContractName { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string ConNum { get; set; }
        public string Sign { get; set; }
        public string Signature { get; set; }
        public string Caddress { get; set; }
        public string Cfax { get; set; }
        public string CompanyNum { get; set; }
        public string Ctel { get; set; }
    }
}
