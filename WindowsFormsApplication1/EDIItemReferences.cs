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
    
    public partial class EDIItemReferences
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string debcode { get; set; }
        public string ItemQualifier { get; set; }
        public string CustomerItemCode { get; set; }
        public double CasePackQty { get; set; }
        public string EDIUOM { get; set; }
        public string AccountingUOM { get; set; }
        public double UnitFactor { get; set; }
        public string InboundOperator { get; set; }
        public string OutboundOperator { get; set; }
        public string Warehouse { get; set; }
        public System.Guid sysguid { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public Nullable<System.DateTime> sysmodified { get; set; }
        public int sysmodifier { get; set; }
    }
}
