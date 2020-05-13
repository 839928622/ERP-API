using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewOrderAfterSale
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int MemberId { get; set; }
        public int GoodsId { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public string ApplyType { get; set; }
        public int ApplyNum { get; set; }
        public string ApplyReason { get; set; }
        public string QuestionDescribe { get; set; }
        public string ReturnWay { get; set; }
        public string PickupAddress { get; set; }
        public DateTime? PickupDate { get; set; }
        public string ReceiveAddress { get; set; }
        public int ApplyUserId { get; set; }
        public string ApplyUserName { get; set; }
        public DateTime ApplyTime { get; set; }
        public string ContactWay { get; set; }
        public string DisplayStatus { get; set; }
        public string InnerStatus { get; set; }
        public int? OperateUserId { get; set; }
        public string OperateUserName { get; set; }
        public string OperateType { get; set; }
        public string OperateMessage { get; set; }
        public DateTime? OperateTime { get; set; }
        public bool IsEvaluate { get; set; }
        public DateTime Updatetime { get; set; }
        public int OrderDetailId { get; set; }
        public string CustomerName { get; set; }
        public int OldNum { get; set; }
        public string HomeImage { get; set; }
    }
}
