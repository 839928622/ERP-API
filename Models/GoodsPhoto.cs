using System;

namespace ERP_API.Models
{
    public partial class GoodsPhoto
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
        public int ImgServerId { get; set; }
    }
}
