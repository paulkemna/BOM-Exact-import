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
    
    public partial class MYTaxRelief
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<short> MaxFrequencyPerYear { get; set; }
        public Nullable<short> interval { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
        public int PayrollYear { get; set; }
    }
}
