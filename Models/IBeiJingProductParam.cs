using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class IBeiJingProductParam
    {
        public int Id { get; set; }
        public string TppvPk { get; set; }
        public string IProductId { get; set; }
        public string TlspPk { get; set; }
        public string IParamName { get; set; }
        public string IParamValue { get; set; }
    }
}
