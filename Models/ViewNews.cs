using System;

namespace ERP_API.Models
{
    public partial class ViewNews
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
        public string TypeName { get; set; }
        public bool IsEnable { get; set; }
        public int TypeBranchId { get; set; }
    }
}
