using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class ViewDistributionCustomerInvoice
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int InvoiceType { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceMoney { get; set; }
        public decimal ChargeOff { get; set; }
        public int LinkManId { get; set; }
        public string LinkMan { get; set; }
        public int DeliveryType { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string BuyerName { get; set; }
        public string BuyerTaxNo { get; set; }
        public string BuyerBank { get; set; }
        public string BuyerBankAccount { get; set; }
        public string BuyerPhone { get; set; }
        public string BuyerAddress { get; set; }
        public string SaleName { get; set; }
        public string SaleTaxNo { get; set; }
        public string SaleBank { get; set; }
        public string SaleBankAccount { get; set; }
        public string SalePhone { get; set; }
        public string SaleAddress { get; set; }
        public string Memo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string BranchName { get; set; }
        public string UserName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool IsDelete { get; set; }
        public int StatementId { get; set; }
    }
}
