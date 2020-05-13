using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class CustomerSetting
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Logo { get; set; }
        public string Image { get; set; }
        public int Tenant { get; set; }
    }
}
