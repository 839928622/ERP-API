using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class SysBranchPayment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Remark { get; set; }
        public int? Type { get; set; }
        public int? PoundageType { get; set; }
        public decimal? PoundageAmount { get; set; }
        public string ApiPath { get; set; }
        public string RedirectUrl { get; set; }
        public string ReturnUrl { get; set; }
        public string NotifyUrl { get; set; }
        public int? SortId { get; set; }
        public int? IsOk { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
