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
    
    public partial class CSPickITCounts
    {
        public int ID { get; set; }
        public int CountRangeID { get; set; }
        public string ItemCode { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> StockQuantity { get; set; }
        public Nullable<double> StockQuantityBefore { get; set; }
        public Nullable<double> SkuStockQuantity { get; set; }
        public byte Processed { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string HandterminalID { get; set; }
        public Nullable<int> OrderPicker { get; set; }
        public Nullable<System.Guid> TransactionGUID { get; set; }
        public string PickITStatus { get; set; }
        public byte IsCount { get; set; }
        public string Project { get; set; }
        public string GLAccountCost { get; set; }
        public string Reference { get; set; }
        public byte Verwerkt { get; set; }
        public int SkuItemID { get; set; }
        public byte IsRecount { get; set; }
        public Nullable<double> RecountedQuantity { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}