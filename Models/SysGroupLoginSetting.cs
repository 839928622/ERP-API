using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysGroupLoginSetting
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string BodyBgColor { get; set; }
        public int WrapperWidth { get; set; }
        public int WrapperMinheight { get; set; }
        public string WrapperBgColor { get; set; }
        public string WrapperBgImg { get; set; }
        public int HeaderHeight { get; set; }
        public string HeaderLogoImg { get; set; }
        public int LoginHeight { get; set; }
        public string LoginBgImg { get; set; }
        public int LoginBoxTop { get; set; }
        public int LoginBoxRight { get; set; }
        public int FooterHeight { get; set; }
        public string FooterBgColor { get; set; }
        public string FooterColor { get; set; }
        public DateTime Updatetime { get; set; }
        public string HeaderBgColor { get; set; }
        public string HeaderBgImg { get; set; }
        public string LoginBoxBgColor { get; set; }
        public int LoginBoxRadius { get; set; }
    }
}
