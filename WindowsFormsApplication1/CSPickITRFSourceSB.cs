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
    
    public partial class CSPickITRFSourceSB
    {
        public int ID { get; set; }
        public int SourceLocID { get; set; }
        public string Number { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> QuantityDisplaced { get; set; }
        public Nullable<double> QuantityPicked { get; set; }
        public byte Ready { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}
