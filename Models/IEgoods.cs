﻿using System;

namespace ERP_API.Models
{
    public partial class IEgoods : BaseEntity
    {
       
        public int ProjectId { get; set; }
        public int GoodsId { get; set; }
        public string CertNo { get; set; }
        public DateTime? CertDate { get; set; }
        public string Url { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
