using System;

namespace ERP_API.Models
{
    public partial class MallFloatAd
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Type { get; set; }
        public string Position { get; set; }
        public string ImgPath { get; set; }
        public string ImgUrl { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string Code { get; set; }
        public bool IsEnable { get; set; }
    }
}
