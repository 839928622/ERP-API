using System;

namespace ERP_API.Models
{
    public partial class AttachedFil
    {
        public int Id { get; set; }
        public int RelationNum { get; set; }
        public int MemberId { get; set; }
        public string FileUrl { get; set; }
        public int Type { get; set; }
        public DateTime AddAt { get; set; }
    }
}
