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
    
    public partial class EbcGroups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EbcGroups()
        {
            this.EbcBrowsers = new HashSet<EbcBrowsers>();
            this.EbcComponents = new HashSet<EbcComponents>();
            this.EbcPropTypes = new HashSet<EbcPropTypes>();
        }
    
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public Nullable<int> TermId { get; set; }
        public string Suffix { get; set; }
        public Nullable<int> SuffixId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EbcBrowsers> EbcBrowsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EbcComponents> EbcComponents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EbcPropTypes> EbcPropTypes { get; set; }
    }
}
