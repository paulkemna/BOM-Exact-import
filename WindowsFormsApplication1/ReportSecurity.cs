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
    
    public partial class ReportSecurity
    {
        public System.Guid ID { get; set; }
        public int Type { get; set; }
        public System.Guid Report { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<int> Resource { get; set; }
        public string Project { get; set; }
        public Nullable<int> RoleLevel { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<short> Division { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
    
        public virtual Reports Reports { get; set; }
    }
}