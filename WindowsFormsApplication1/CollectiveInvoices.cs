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
    
    public partial class CollectiveInvoices
    {
        public int ID { get; set; }
        public string CollectiveInvoiceNumber { get; set; }
        public string InvoiceDebtor { get; set; }
        public short InvoiceYear { get; set; }
        public byte InvoiceMonth { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public double PreviousOutstandingAmount { get; set; }
        public double ReceivedAmount { get; set; }
        public double InvoiceAmount { get; set; }
        public double VATAmount { get; set; }
        public double InvoiceTotal { get; set; }
        public double CurrentOutstandingAmount { get; set; }
        public string ParentAccount { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> InvoiceClosingDate { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
    }
}
