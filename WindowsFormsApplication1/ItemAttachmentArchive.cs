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
    
    public partial class ItemAttachmentArchive
    {
        public System.Guid ID { get; set; }
        public string ItemCode { get; set; }
        public System.Guid ReleaseID { get; set; }
        public System.DateTime ArchiveDate { get; set; }
        public int Archiver { get; set; }
        public byte[] Attachment { get; set; }
        public string AttachmentFileName { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string LastModifier { get; set; }
        public string FileVersion { get; set; }
        public Nullable<short> Division { get; set; }
    }
}
