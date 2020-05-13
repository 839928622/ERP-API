using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewTransfer
    {
        public int Id { get; set; }
        public int OutBranchId { get; set; }
        public int OutStoreId { get; set; }
        public int OutStoreUserId { get; set; }
        public DateTime OutStoreDate { get; set; }
        public string OutStatus { get; set; }
        public int LogisticsInfomationId { get; set; }
        public int InBranchId { get; set; }
        public int InStoreId { get; set; }
        public int InStoreUserId { get; set; }
        public DateTime InStoreDate { get; set; }
        public string InStatus { get; set; }
        public string Memo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int RowNum { get; set; }
        public decimal SumMoney { get; set; }
        public int UserId { get; set; }
        public bool IsDelete { get; set; }
        public bool IsChecked { get; set; }
        public string OutBranchName { get; set; }
        public string InBranchName { get; set; }
        public string OutStoreName { get; set; }
        public string InStoreName { get; set; }
        public string OutStoreUserName { get; set; }
        public string InStoreUserName { get; set; }
        public string UserName { get; set; }
        public DateTime AddTime { get; set; }
        public bool IsArchive { get; set; }
    }
}
