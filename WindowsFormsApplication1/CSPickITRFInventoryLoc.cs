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
    
    public partial class CSPickITRFInventoryLoc
    {
        public int ID { get; set; }
        public int StockTransID { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string SerialBatchItem { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> QuantityPicked { get; set; }
        public string UserID { get; set; }
        public string HandTerminalID { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}