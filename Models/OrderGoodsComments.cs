using System;

namespace ERP_API.Models
{
    public partial class OrderGoodsComments
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int OrderDetailId { get; set; }
        public string Type { get; set; }
        public int MemberId { get; set; }
        public int Score { get; set; }
        public string CommentContent { get; set; }
        public int Recommend { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Label { get; set; }
        public string Status { get; set; }
    }
}
