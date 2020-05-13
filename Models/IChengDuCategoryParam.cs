using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IChengDuCategoryParam
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Vals { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
