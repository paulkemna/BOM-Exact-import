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
    
    public partial class ItemAccounts
    {
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public System.Guid AccountCode { get; set; }
        public string crdnr { get; set; }
        public bool MainAccount { get; set; }
        public string ItemCodeAccount { get; set; }
        public string EANCode { get; set; }
        public string PurchaseCurrency { get; set; }
        public double PurchasePrice { get; set; }
        public string PurchaseVATCode { get; set; }
        public double PurchaseVATPerc { get; set; }
        public bool PurchaseVATIncl { get; set; }
        public string PurchaseUnit { get; set; }
        public string PurchasePackage { get; set; }
        public double PurchaseUnitToInternalUnitFactor { get; set; }
        public double PurchaseUnitToPurchasePackageFactor { get; set; }
        public double PurchaseOrderSize { get; set; }
        public double DiscountMargin { get; set; }
        public double SalesPriceRecommended { get; set; }
        public double SlsPkgsPerPurPkg { get; set; }
        public int DeliveryTimeInDays { get; set; }
        public bool DeliverableFromStock { get; set; }
        public Nullable<System.Guid> DocumentID { get; set; }
        public Nullable<byte> SupplierPreference { get; set; }
        public Nullable<double> StatisticalFactor { get; set; }
        public int Warranty { get; set; }
        public string CountryOfOrigin { get; set; }
        public Nullable<short> Division { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
        public bool DropShip { get; set; }
        public string CountryOfAssembly { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<double> CSPickITStandardBatchQty { get; set; }
        public Nullable<int> CSPickITIncrementFactor { get; set; }
    }
}
