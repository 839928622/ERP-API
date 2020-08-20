using System;

namespace ERP_API.Models
{
    public partial class ServiceOrderLog
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string ServiceCode { get; set; }
        public int Type { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public int? LastModifierUserId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? DeleterUserId { get; set; }
        public string Remark { get; set; }
        public int Tenant { get; set; }
    }
}
