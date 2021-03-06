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
    
    public partial class EbcPropTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EbcPropTypes()
        {
            this.EbcProps = new HashSet<EbcProps>();
        }
    
        public System.Guid PropTypeId { get; set; }
        public int GroupId { get; set; }
        public int BasicTypeId { get; set; }
        public string TypeName { get; set; }
        public int PropPrecision { get; set; }
        public string PrecisionQuery { get; set; }
        public int PropScale { get; set; }
        public bool PropUppercase { get; set; }
        public bool PropUnsigned { get; set; }
        public bool ExactMatch { get; set; }
        public bool LanguageDependent { get; set; }
        public bool NumericString { get; set; }
        public bool RightAligned { get; set; }
        public bool ZeroFill { get; set; }
        public bool AutoIncrement { get; set; }
        public bool ZeroIsNull { get; set; }
        public string DefaultValue { get; set; }
        public string LowerRange { get; set; }
        public string UpperRange { get; set; }
        public string SelectionValues { get; set; }
        public string AllowedChars { get; set; }
        public string AllowedCharsQuery { get; set; }
    
        public virtual EbcBasicTypes EbcBasicTypes { get; set; }
        public virtual EbcGroups EbcGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EbcProps> EbcProps { get; set; }
    }
}
