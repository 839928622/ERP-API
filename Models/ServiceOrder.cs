using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ServiceOrder
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public int? RelationId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int Province { get; set; }
        public string ProvinceName { get; set; }
        public int City { get; set; }
        public string CityName { get; set; }
        public int Country { get; set; }
        public string CountryName { get; set; }
        public string Address { get; set; }
        public DateTime PlantTime { get; set; }
        public int Status { get; set; }
        public int FlowState { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public int? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? DeleterUserId { get; set; }
        public string Remark { get; set; }
        public int Tenant { get; set; }
        public int ApplyUserId { get; set; }
        public string ApplyUserName { get; set; }
        public decimal SumMoney { get; set; }
        public DateTime? LastPrintTime { get; set; }
    }
}
