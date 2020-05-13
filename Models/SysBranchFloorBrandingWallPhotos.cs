using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchFloorBrandingWallPhotos
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public string ImgHref { get; set; }
        public int BranchFloorId { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime AddTime { get; set; }
        public int Sort { get; set; }
        public bool IsDelete { get; set; }
    }
}
