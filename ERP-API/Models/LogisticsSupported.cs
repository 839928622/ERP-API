using System;

namespace ERP_API.Models
{
    public partial class LogisticsSupported
    {
        public int Id { get; set; }
        public string LogisticsCompany { get; set; }
        public string Code { get; set; }
        public string Memo { get; set; }
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
