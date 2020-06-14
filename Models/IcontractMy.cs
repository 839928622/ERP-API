using System;

namespace ERP_API.Models
{
    public partial class IcontractMy
    {
        public int Id { get; set; }
        public int IprojectId { get; set; }
        public int BranchId { get; set; }
        public int OrderId { get; set; }
        public string FileName { get; set; }
        public string FileByte { get; set; }
        public string FileByted { get; set; }
        public bool IsSigned { get; set; }
        public string FielUrl { get; set; }
        public DateTime DtSubmitTime { get; set; }
        public DateTime? DtSignTime { get; set; }
    }
}
