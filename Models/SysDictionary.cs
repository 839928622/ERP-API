using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysDictionary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public int ParentId { get; set; }
        public int Sort { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDelete { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string CreateName { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual SysDictionaryType Type { get; set; }
    }
}
