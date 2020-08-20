using System;

namespace ERP_API.Models
{
    public partial class SysBranchThemeAreaGoodsTab
    {
        public int Id { get; set; }
        public int ThemeAreaId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SearchType { get; set; }
        public bool IsShowHead { get; set; }
        public int Sort { get; set; }
        public string TabHref { get; set; }
        public bool IsEnable { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
