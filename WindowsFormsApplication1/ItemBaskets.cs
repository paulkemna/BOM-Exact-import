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
    
    public partial class ItemBaskets
    {
        public System.Guid ID { get; set; }
        public int BasketMode { get; set; }
        public int BasketStatus { get; set; }
        public int BasketOwner { get; set; }
        public int Resource { get; set; }
        public Nullable<System.Guid> Account { get; set; }
        public Nullable<System.Guid> AccountInvoice { get; set; }
        public int RequestType { get; set; }
        public Nullable<System.Guid> RequestID { get; set; }
        public string ItemCode { get; set; }
        public string CountryCode { get; set; }
        public double Quantity { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<System.Guid> PriceID { get; set; }
        public int PriceQuantity { get; set; }
        public double PriceLocal { get; set; }
        public double Price { get; set; }
        public string OrderNumber { get; set; }
        public string ProcessNumber { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Project { get; set; }
        public int BillingType { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<int> Creator { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<int> Modifier { get; set; }
        public Nullable<System.DateTime> Processed { get; set; }
        public Nullable<int> Processor { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public Nullable<short> Division { get; set; }
    }
}
