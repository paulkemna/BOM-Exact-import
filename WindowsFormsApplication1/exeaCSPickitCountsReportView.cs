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
    
    public partial class exeaCSPickitCountsReportView
    {
        public int CountRangeID { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public string Reference { get; set; }
        public int CountID { get; set; }
        public int CountSBID { get; set; }
        public string Warehouse { get; set; }
        public string ItemCode { get; set; }
        public string Location { get; set; }
        public Nullable<double> StockQtyHeader { get; set; }
        public Nullable<double> QtyHeader { get; set; }
        public Nullable<double> QtyRecountedHeader { get; set; }
        public string number { get; set; }
        public string facode { get; set; }
        public Nullable<double> StockQuantity { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string HandterminalID { get; set; }
        public Nullable<int> OrderPicker { get; set; }
        public string PickITStatus { get; set; }
        public byte IsCount { get; set; }
        public byte IsRecountHeader { get; set; }
        public byte IsParent { get; set; }
        public string ScanUnit { get; set; }
        public string OuterSku { get; set; }
        public string InnerSku { get; set; }
        public int HasRecount { get; set; }
        public double QtyRecountedSB { get; set; }
        public Nullable<System.Guid> ReportGuid { get; set; }
        public string ItemDescription { get; set; }
        public double CostPriceStandard { get; set; }
        public string ItemSBtype { get; set; }
        public bool IsFractionAllowedItem { get; set; }
    }
}
