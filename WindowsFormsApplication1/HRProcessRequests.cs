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
    
    public partial class HRProcessRequests
    {
        public int ID { get; set; }
        public int SequenceNumber { get; set; }
        public string ProcessDescription { get; set; }
        public Nullable<int> RequestType { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string Description { get; set; }
        public Nullable<int> UseRequest { get; set; }
        public Nullable<int> PreviousRequest { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> UseDate { get; set; }
        public double Days { get; set; }
        public double DurationInDays { get; set; }
        public int Frequency { get; set; }
        public int NumberFrequency { get; set; }
        public int Maximum { get; set; }
        public bool Overdue { get; set; }
        public Nullable<System.Guid> Freefield_1 { get; set; }
        public Nullable<System.Guid> Freefield_2 { get; set; }
        public string FreeTextField_1 { get; set; }
        public string FreeTextField_2 { get; set; }
        public Nullable<bool> FreeBoolField_1 { get; set; }
        public Nullable<bool> FreeBoolField_2 { get; set; }
        public Nullable<double> FreeNumberField_1 { get; set; }
        public Nullable<double> FreeNumberField_2 { get; set; }
        public Nullable<int> FreeIntField_1 { get; set; }
        public Nullable<int> FreeIntField_2 { get; set; }
        public int ProcessTypesID { get; set; }
        public bool Active { get; set; }
        public bool Blocked { get; set; }
        public Nullable<short> Division { get; set; }
        public string Remark { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public byte[] timestamp { get; set; }
    }
}