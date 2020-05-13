using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewSupplierDetail
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int GoodsId { get; set; }
        public decimal BillsPrice { get; set; }
        public decimal InPrice { get; set; }
        public int Num { get; set; }
        public decimal Amount { get; set; }
        public int ReceivedNum { get; set; }
        public bool IsEmergency { get; set; }
        public int SupplierNum { get; set; }
        public DateTime DelayDate { get; set; }
        public string PurchaseStatus { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
    }
}
