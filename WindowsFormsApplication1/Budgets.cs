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
    
    public partial class Budgets
    {
        public System.Guid BudgetID { get; set; }
        public string CompanyCode { get; set; }
        public string ScenarioCode { get; set; }
        public int ScenarioVersion { get; set; }
        public int FinYear { get; set; }
        public int FinPeriod { get; set; }
        public string CompanyAccountCategory { get; set; }
        public string CompanyAccountCode { get; set; }
        public string CompanyCostcenterCode { get; set; }
        public string CompanyCostunitCode { get; set; }
        public string CurrencyCode { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public string CurrencyAliasAC { get; set; }
        public double AmountAC { get; set; }
        public byte[] timestamp { get; set; }
        public string ItemCode { get; set; }
        public Nullable<short> Division { get; set; }
        public Nullable<double> Quantity { get; set; }
    }
}