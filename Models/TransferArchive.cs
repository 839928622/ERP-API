using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class TransferArchive
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int Page { get; set; }
        public string PhotoUrl { get; set; }
        public int SaveNum { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int AllPage { get; set; }
    }
}
