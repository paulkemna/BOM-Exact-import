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
    
    public partial class ExactLicense
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public short Type { get; set; }
        public string Number { get; set; }
        public int SequenceNumber { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime ActivationDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public int Checksum { get; set; }
        public Nullable<short> Division { get; set; }
        public byte[] Certificate { get; set; }
    }
}
