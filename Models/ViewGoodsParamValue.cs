using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewGoodsParamValue
    {
        public int GoodsId { get; set; }
        public int ParamId { get; set; }
        public string Value { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public bool HasOption { get; set; }
        public bool IsCondition { get; set; }
        public int TypeId { get; set; }
        public string GroupName { get; set; }
        public int GroupSort { get; set; }
    }
}
