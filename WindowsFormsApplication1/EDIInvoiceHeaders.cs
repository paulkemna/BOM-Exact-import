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
    
    public partial class EDIInvoiceHeaders
    {
        public int ID { get; set; }
        public string InvoiceCode { get; set; }
        public string SeqNumber { get; set; }
        public string OurRef { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> EarlyShipDate { get; set; }
        public Nullable<System.DateTime> RequestedShipDate { get; set; }
        public string Department { get; set; }
        public Nullable<double> TotalTare { get; set; }
        public Nullable<double> TotalPacks { get; set; }
        public string BOLNo { get; set; }
        public string PRONo { get; set; }
        public Nullable<double> TotalCartons { get; set; }
        public Nullable<double> TotalWeight { get; set; }
        public string ShiptoID { get; set; }
        public string DistributionCenterID { get; set; }
        public string DestinationName { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
    }
}
