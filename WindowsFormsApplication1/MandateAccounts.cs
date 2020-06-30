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
    
    public partial class MandateAccounts
    {
        public int ID { get; set; }
        public System.Guid Account { get; set; }
        public string Reference { get; set; }
        public Nullable<System.DateTime> SignatureDate { get; set; }
        public Nullable<System.DateTime> CancellationDate { get; set; }
        public string SortOfMandate { get; set; }
        public string BankAccountNumber { get; set; }
        public Nullable<System.DateTime> LastSEPADirectDebitDate { get; set; }
        public Nullable<System.Guid> DocAttachmentID { get; set; }
        public string SequenceType { get; set; }
        public string OldReference { get; set; }
        public Nullable<System.DateTime> OldSignatureDate { get; set; }
        public Nullable<System.DateTime> OldCancellationDate { get; set; }
        public string OldBankAccountNumber { get; set; }
        public Nullable<System.Guid> OldDocAttachmentID { get; set; }
        public bool MandateChanged { get; set; }
        public bool BankAccountNumberChanged { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public string PaymentCondition { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> OldLastSEPADirectDebitDate { get; set; }
        public Nullable<int> StartBatch { get; set; }
        public Nullable<int> EndBatch { get; set; }
        public bool BankChanged { get; set; }
    }
}