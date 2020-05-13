using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string ProductPlace { get; set; }
        public string WebSite { get; set; }
        public string LogoUrl { get; set; }
        public int BranchId { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Py { get; set; }
    }
}
