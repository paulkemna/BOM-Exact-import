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
    
    public partial class CSPickItWebRequests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CSPickItWebRequests()
        {
            this.CSPickItWebFormFields = new HashSet<CSPickItWebFormFields>();
        }
    
        public int ID { get; set; }
        public int WebSessionID { get; set; }
        public string Url { get; set; }
        public string Response { get; set; }
        public string HandTerminalId { get; set; }
        public string UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CSPickItWebFormFields> CSPickItWebFormFields { get; set; }
        public virtual CSPickItWebSessions CSPickItWebSessions { get; set; }
    }
}
