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
    
    public partial class BacoFunctionRoles
    {
        public System.Guid ID { get; set; }
        public int FunctionID { get; set; }
        public int RoleID { get; set; }
        public int RoleLevel { get; set; }
        public Nullable<short> Division { get; set; }
    
        public virtual BacoFunctions BacoFunctions { get; set; }
    }
}
