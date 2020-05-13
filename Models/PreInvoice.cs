using System;
using System.Collections.Generic;

namespace ERP_API.Models
{
    public partial class PreInvoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceContent { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceRemark { get; set; }
        public string InvoiceEmail { get; set; }
        public string InvoiceMobile { get; set; }
        public string BuyerTaxNum { get; set; }
        public string BuyerBank { get; set; }
        public string BuyerBankAccount { get; set; }
        public string BuyerAddress { get; set; }
        public string SaleName { get; set; }
        public string SaleTaxNum { get; set; }
        public string SaleBank { get; set; }
        public string SaleBankAccount { get; set; }
        public string SalePhone { get; set; }
        public string SaleAddress { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DistributionType { get; set; }
        public int MemberId { get; set; }
        public decimal InitialAmount { get; set; }
        public string Operate { get; set; }
        public decimal PreInvoiceAmount { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string UserName { get; set; }
        public decimal Balance { get; set; }
        public int BranchId { get; set; }
    }
}
