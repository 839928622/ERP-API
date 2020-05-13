using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysCity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Pcode { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
