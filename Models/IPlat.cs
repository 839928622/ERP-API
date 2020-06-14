using System;

namespace ERP_API.Models
{
    public partial class IPlat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IProviderId { get; set; }
        public bool? IsPostData { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
