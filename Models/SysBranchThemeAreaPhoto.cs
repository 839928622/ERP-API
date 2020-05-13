using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchThemeAreaPhoto
    {
        public int Id { get; set; }
        public int ThemeAreaId { get; set; }
        public int Sort { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ImgHref { get; set; }
        public string ImgUrl { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsEnable { get; set; }
    }
}
