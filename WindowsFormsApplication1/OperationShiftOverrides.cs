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
    
    public partial class OperationShiftOverrides
    {
        public int ID { get; set; }
        public Nullable<System.Guid> Shiftguid { get; set; }
        public Nullable<System.Guid> Operationguid { get; set; }
        public int ScheduledResources { get; set; }
        public Nullable<System.DateTime> ShiftDate { get; set; }
        public Nullable<double> ShiftHours { get; set; }
        public Nullable<bool> IsWorkDay { get; set; }
        public System.Guid sysguid { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid ObjectGUID { get; set; }
    }
}