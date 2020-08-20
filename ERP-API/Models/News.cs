using System;

namespace ERP_API.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Title { get; set; }
        public int NewsTypeId { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Content { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsTop { get; set; }
        public bool? IsEnable { get; set; }
    }
}
