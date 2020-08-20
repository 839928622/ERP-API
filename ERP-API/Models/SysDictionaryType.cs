using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysDictionaryType
    {
        public SysDictionaryType()
        {
            SysDictionary = new HashSet<SysDictionary>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public bool IsDelete { get; set; }
        public int BranchId { get; set; }
        public bool IsSystem { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual ICollection<SysDictionary> SysDictionary { get; set; }
    }
}
