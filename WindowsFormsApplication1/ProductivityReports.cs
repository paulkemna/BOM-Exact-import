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
    
    public partial class ProductivityReports
    {
        public int ID { get; set; }
        public string Division { get; set; }
        public string Costcenter { get; set; }
        public int Resource { get; set; }
        public string Project { get; set; }
        public string Activity { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public double BudgetCostsInQTY { get; set; }
        public double ActualCostsInQTY { get; set; }
        public double BudgetCostsInAmt { get; set; }
        public double ActualCostsInAmt { get; set; }
        public double CapacityOrAvailabilityInQty { get; set; }
        public double AbsenceInQty { get; set; }
        public double BudgetRevenueInQty { get; set; }
        public double ActualRevenueInQty { get; set; }
        public double BudgetRevenueInAmt { get; set; }
        public double ActualRevenueInAmt { get; set; }
        public Nullable<short> DivisionX { get; set; }
        public string RequestHID { get; set; }
    }
}
