using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewGoodsPhoto
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsHomeImage { get; set; }
        public bool IsDetailPhoto { get; set; }
        public int Sort { get; set; }
        public int? UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Photo250Url { get; set; }
        public string Photo100Url { get; set; }
        public int ParentId { get; set; }
        public int BranchId { get; set; }
        public int ImgServerId { get; set; }
    }
}
