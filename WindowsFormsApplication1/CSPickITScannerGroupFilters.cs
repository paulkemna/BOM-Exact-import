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
    
    public partial class CSPickITScannerGroupFilters
    {
        public int ID { get; set; }
        public string Warehouse { get; set; }
        public string PickITModule { get; set; }
        public string CSPickITHandTerminalGroup { get; set; }
        public byte LocationTypeBulk { get; set; }
        public byte LocationTypePick { get; set; }
        public byte LocationTypeNone { get; set; }
        public byte ScanUnitSales { get; set; }
        public byte ScanUnitOuter { get; set; }
        public byte ScanUnitInner { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
        public string ItemCodeMin { get; set; }
        public string ItemCodeMax { get; set; }
        public byte ItemCodeAll { get; set; }
        public int ItemGroupMin { get; set; }
        public int ItemGroupMax { get; set; }
        public byte ItemGroupAll { get; set; }
        public string PickingClassMin { get; set; }
        public string PickingClassMax { get; set; }
        public byte PickingClassAll { get; set; }
        public string LocationMin { get; set; }
        public string LocationMax { get; set; }
        public byte LocationAll { get; set; }
        public string ZoneMin { get; set; }
        public string ZoneMax { get; set; }
        public byte ZoneAll { get; set; }
    }
}
