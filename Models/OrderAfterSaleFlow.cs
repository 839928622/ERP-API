using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class OrderAfterSaleFlow
    {
        public int Id { get; set; }
        public int AfterSaleId { get; set; }
        public int OrderId { get; set; }
        public string OperateType { get; set; }
        public int OperateUserId { get; set; }
        public string OperateUserName { get; set; }
        public string OperateMessage { get; set; }
        public string Memo { get; set; }
        public string DisplayStatus { get; set; }
        public string InnerStatus { get; set; }
        public DateTime AddTime { get; set; }
    }
}
