using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class NotifyTemplet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mode { get; set; }
        public int Type { get; set; }
        public int? SignId { get; set; }
        public long? Code { get; set; }
        public string Title { get; set; }
        public string Templet { get; set; }
        public string DisplayTemplet { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public int? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public int? DeleterUserId { get; set; }
        public string Remark { get; set; }
        public int Tenant { get; set; }
    }
}
