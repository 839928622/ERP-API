using System;

namespace ERP_API.Models
{
    public partial class GoodsCaptcha
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public string Captcha { get; set; }
        public int BranchId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
