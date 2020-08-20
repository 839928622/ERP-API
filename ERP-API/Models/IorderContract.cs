using System;

namespace ERP_API.Models
{
    public partial class IorderContract
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
    }
}
