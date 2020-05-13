using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysAgent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public string Bank { get; set; }
        public string AcountNo { get; set; }
        public string LinkMan { get; set; }
        public string Telphone { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
