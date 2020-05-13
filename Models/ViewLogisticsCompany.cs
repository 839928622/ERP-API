using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewLogisticsCompany
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDisable { get; set; }
        public int SupportedId { get; set; }
        public string LogisticsCompany { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
        public string Type { get; set; }
    }
}
