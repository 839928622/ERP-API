using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PreGoodsPhoto
    {
        public int Id { get; set; }
        public string GoodsId { get; set; }
        public string PhotoUrl { get; set; }
        public bool? IsHomeImage { get; set; }
        public bool? IsDetailPhoto { get; set; }
    }
}
