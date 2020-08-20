using System;

namespace ERP_API.Models
{
    public partial class NotifySetting
    {
        public int Id { get; set; }
        public string AppKey { get; set; }
        public string Email { get; set; }
        public string EmailName { get; set; }
        public string EmailPsw { get; set; }
        public string EmailSmtp { get; set; }
        public string EmailNickName { get; set; }
        public bool IsEnabled { get; set; }
        public int Type { get; set; }
        public string Extend1 { get; set; }
        public string Extend2 { get; set; }
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
