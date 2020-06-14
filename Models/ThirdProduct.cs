using System;

namespace ERP_API.Models
{
    public partial class ThirdProduct
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Source { get; set; }
        public int GoodsId { get; set; }
        public string Introduction { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public int? PhotoNum { get; set; }
        public int? DetailPhotoNum { get; set; }
    }
}
