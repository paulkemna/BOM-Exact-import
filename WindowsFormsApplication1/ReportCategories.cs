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
    
    public partial class ReportCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportCategories()
        {
            this.ReportCategories1 = new HashSet<ReportCategories>();
            this.Reports = new HashSet<Reports>();
        }
    
        public System.Guid ID { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> Parent { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<short> Division { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
    
        public virtual BacoProducts BacoProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportCategories> ReportCategories1 { get; set; }
        public virtual ReportCategories ReportCategories2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
