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
    
    public partial class ItemReleases
    {
        public System.Guid ID { get; set; }
        public string ProductLine { get; set; }
        public string ProductRelease { get; set; }
        public int Assortment { get; set; }
        public string Release { get; set; }
        public int Status { get; set; }
        public int DownloadSecurityLevel { get; set; }
        public bool DownloadSecurityLevelCombine { get; set; }
        public bool UploadItemOwner { get; set; }
        public bool UploadItemOwnerManager { get; set; }
        public int UploadRole { get; set; }
        public int UploadRoleLevel { get; set; }
        public bool AllowUpload { get; set; }
        public bool AllowCheckout { get; set; }
        public bool AllowTouch { get; set; }
        public bool AllowArchive { get; set; }
        public bool AllowArchiveChildren { get; set; }
        public Nullable<int> DownloadRole { get; set; }
        public Nullable<int> DownloadRoleLevel { get; set; }
        public Nullable<short> Division { get; set; }
        public byte[] timestamp { get; set; }
    }
}
