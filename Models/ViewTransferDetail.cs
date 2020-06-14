using System;

namespace ERP_API.Models
{
    public partial class ViewTransferDetail
    {
        public int TransferId { get; set; }
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
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public int Num { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public int PickNum { get; set; }
        public int ReceivedNum { get; set; }
        public string ReceivedStatus { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public DateTime AddTime { get; set; }
        public int? StockNum { get; set; }
        public string SingleRemark { get; set; }
    }
}
