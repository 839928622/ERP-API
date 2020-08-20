using System;

namespace ERP_API.Models
{
    public partial class NotifyMsg
    {
        public int Id { get; set; }
        public int TempletId { get; set; }
        public string TempletValue { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? SendId { get; set; }
        public int? ReceiveId { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int Item { get; set; }
        public int? RelationId { get; set; }
        public string Extend1 { get; set; }
        public int? Extend2 { get; set; }
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
