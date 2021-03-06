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
    
    public partial class CSPickITSKUItem
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public string SKUItemDescription { get; set; }
        public string OuterSKUType { get; set; }
        public double OuterSKUQuantity { get; set; }
        public string OuterSKUDescription { get; set; }
        public string InnerSKUType { get; set; }
        public double InnerSKUQuantity { get; set; }
        public string InnerSKUDescription { get; set; }
        public byte Autopack { get; set; }
        public string AllowBreaking { get; set; }
        public byte Stackable { get; set; }
        public byte AllowMore { get; set; }
        public byte IsInnerSKU { get; set; }
        public byte IsOuterSKU { get; set; }
        public int OuterSKUDimensionHeight { get; set; }
        public int OuterSKUDimensionWidth { get; set; }
        public int OuterSKUDimensionDepth { get; set; }
        public int InnerSKUDimensionHeight { get; set; }
        public int InnerSKUDimensionWidth { get; set; }
        public int InnerSKUDimensionDepth { get; set; }
        public string ReplenishmentBy { get; set; }
        public byte IsActive { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
        public double MaximumSKUQuantity { get; set; }
    }
}
