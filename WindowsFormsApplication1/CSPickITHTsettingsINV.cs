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
    
    public partial class CSPickITHTsettingsINV
    {
        public int ID { get; set; }
        public string SettingName { get; set; }
        public string Description { get; set; }
        public byte INVBrowseOrdLines { get; set; }
        public byte INVShowPickedLines { get; set; }
        public byte INVMenuGuided { get; set; }
        public byte INVMenuFree { get; set; }
        public byte INVMenuView { get; set; }
        public byte INVMenuDelete { get; set; }
        public string INVGSBDef { get; set; }
        public string INVFocusTo { get; set; }
        public string INVItemDef { get; set; }
        public byte INVItemLookup { get; set; }
        public byte INVItemVal { get; set; }
        public string INVLocationDef { get; set; }
        public string INVLocationNFLD { get; set; }
        public Nullable<double> INVQuantityDef { get; set; }
        public Nullable<double> INVQuantityMax { get; set; }
        public Nullable<double> INVQuantityMin { get; set; }
        public string INVQuantityNFLD { get; set; }
        public byte INVStockBrowse { get; set; }
        public string INVWarehouseDef { get; set; }
        public string INVWarehouseNFLD { get; set; }
        public byte INVScanComb { get; set; }
        public string INVScanCombChar { get; set; }
        public byte INVEAN128 { get; set; }
        public byte INVFocusToNextField { get; set; }
        public byte INVAutoOpenSkuScreen { get; set; }
        public byte INVBestBeforeDateSerialItem { get; set; }
        public byte INVBestBeforeDateBatchItem { get; set; }
        public byte INVProdDateSerialItem { get; set; }
        public byte INVProdDateBatchItem { get; set; }
        public string INVDetailedScreen { get; set; }
        public byte INVBarcodePopup { get; set; }
        public byte INVAcceptExtSkus { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}