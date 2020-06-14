using System;

namespace ERP_API.Models
{
    public partial class LogisticsInfomation
    {
        public int Id { get; set; }
        public int LogisticsCompanyId { get; set; }
        public string TrackingNumber { get; set; }
        public string FromUser { get; set; }
        public string FromTelphone { get; set; }
        public string FromAddress { get; set; }
        public string ToUser { get; set; }
        public string ToTelphone { get; set; }
        public string ToAddress { get; set; }
        public string ImgUrl { get; set; }
        public DateTime UpdateTime { get; set; }
        public int OrderId { get; set; }
        public string LogisticsInfo { get; set; }
        public int? OrderType { get; set; }
    }
}
