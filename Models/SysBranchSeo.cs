using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchSeo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Tenant { get; set; }
    }
}
