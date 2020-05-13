using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderGoodsComments
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string Type { get; set; }
        public int MemberId { get; set; }
        public int Score { get; set; }
        public string CommentContent { get; set; }
        public string Status { get; set; }
        public int Recommend { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Label { get; set; }
        public int? OrderId { get; set; }
        public int? Num { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string RealName { get; set; }
        public int? MemberBranchId { get; set; }
        public int? GoodsBranchId { get; set; }
        public bool? IsComment { get; set; }
        public int OrderDetailId { get; set; }
        public DateTime? OrderTime { get; set; }
        public decimal? SumMoney { get; set; }
        public string PayType { get; set; }
        public string PayStatus { get; set; }
        public string ServiceStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public bool? IsEnable { get; set; }
        public bool? IsDelete { get; set; }
        public string DisplayName { get; set; }
    }
}
