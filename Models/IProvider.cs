using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
