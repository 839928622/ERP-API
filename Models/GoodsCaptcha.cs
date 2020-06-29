using System;

namespace ERP_API.Models
{
    public partial class GoodsCaptcha : BaseEntity
    {
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public string Captcha { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
