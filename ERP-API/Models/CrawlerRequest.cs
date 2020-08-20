using System;

namespace ERP_API.Models
{
    public partial class CrawlerRequest : BaseEntity
    {
      
        public string Url { get; set; }
        public int DataSource { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsGrabGroup { get; set; }
        public int SuccessNum { get; set; }
        public int FailNum { get; set; }
        public string Remark { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
