//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Balance
    {
        public System.Guid ID { get; set; }
        public string CompanyCode { get; set; }
        public int FinYear { get; set; }
        public int FinPeriod { get; set; }
        public string CompanyAccountCode { get; set; }
        public string CompanyCostcenterCode { get; set; }
        public string CompanyCostunitCode { get; set; }
        public string CurrencyCode { get; set; }
        public double AmountDebit { get; set; }
        public double AmountCredit { get; set; }
        public string CurrencyAliasAC { get; set; }
        public double AmountDebitAC { get; set; }
        public double AmountCreditAC { get; set; }
        public string transtype { get; set; }
        public string Warehouse { get; set; }
        public byte[] timestamp { get; set; }
        public string ItemCode { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<short> Division { get; set; }
    }
}
