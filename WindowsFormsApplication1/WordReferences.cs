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
    
    public partial class WordReferences
    {
        public int Word { get; set; }
        public System.Guid Entity { get; set; }
        public int EntityType { get; set; }
        public int SecurityLevel { get; set; }
        public string Language { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<bool> InSubject { get; set; }
        public Nullable<bool> InSummary { get; set; }
        public Nullable<int> InDocCount { get; set; }
        public Nullable<int> InAttachmentCount { get; set; }
    }
}