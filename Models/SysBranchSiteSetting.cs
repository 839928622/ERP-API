using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchSiteSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string SiteName { get; set; }
        public string LogoUrl { get; set; }
        public string Telphone { get; set; }
        public bool UseGoodsTypes { get; set; }
        public bool UseTopMenus { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string IcpNo { get; set; }
        public string CompanyTelphone { get; set; }
        public bool IsShowSubGoods { get; set; }
        public bool UseQqcustomer { get; set; }
        public string Qq { get; set; }
        public string IconUrl { get; set; }
        public string VerificationCodeName { get; set; }
        public string ContactImage { get; set; }
        public string HtmlValidate { get; set; }
        public string Qrcode { get; set; }
        public string SubTelphone { get; set; }
    }
}
