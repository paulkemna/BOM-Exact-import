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
    
    public partial class CSPickITRejectionStatistics
    {
        public int ID { get; set; }
        public string PickITModule { get; set; }
        public string Number { get; set; }
        public string ItemCode { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseLocation { get; set; }
        public string RejectionReason { get; set; }
        public string SerialBatchNumber { get; set; }
        public Nullable<double> Quantity { get; set; }
        public byte BlockStock { get; set; }
        public string HandTerminalID { get; set; }
        public string OuterSku { get; set; }
        public string InnerSku { get; set; }
        public string ScanUnit { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}