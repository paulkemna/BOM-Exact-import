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
    
    public partial class ItemPrices
    {
        public System.Guid ID { get; set; }
        public string ItemCode { get; set; }
        public string CountryCode { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public int Quantity { get; set; }
        public bool DefaultPrice { get; set; }
        public string Description { get; set; }
        public string SalesCurrency { get; set; }
        public double SalesPrice { get; set; }
        public double SalesPriceTotal { get; set; }
        public double SalesVATPerc { get; set; }
        public bool SalesVATIncl { get; set; }
        public double SalesMarginPerc { get; set; }
        public double SalesMarginDefaultPerc { get; set; }
        public Nullable<short> Division { get; set; }
        public byte[] timestamp { get; set; }
    }
}
