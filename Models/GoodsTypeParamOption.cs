using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class GoodsTypeParamOption
    {
        public int Id { get; set; }
        public int ParamId { get; set; }
        public string Value { get; set; }
        public int Sort { get; set; }
    }
}
