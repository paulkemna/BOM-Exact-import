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
    
    public partial class BacoDiscussionVersions
    {
        public System.Guid ID { get; set; }
        public int HID { get; set; }
        public System.Guid DocumentID { get; set; }
        public string Version { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Filename { get; set; }
        public byte[] Attachment { get; set; }
        public int Status { get; set; }
        public string StatusText { get; set; }
        public string FPIntroText { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string VersionNote { get; set; }
        public Nullable<System.DateTime> CheckedOut { get; set; }
        public Nullable<int> CheckedOutBy { get; set; }
        public Nullable<short> Division { get; set; }
        public byte[] timestamp { get; set; }
    }
}
