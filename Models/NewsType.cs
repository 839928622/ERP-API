using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class NewsType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreateDate { get; set; }
        public int BranchId { get; set; }
    }
}
