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
    
    public partial class EntityTransactions
    {
        public int ID { get; set; }
        public System.Guid TransactionKey { get; set; }
        public string EntityName { get; set; }
        public string XMLData { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.Guid TableKey { get; set; }
        public Nullable<byte> Status { get; set; }
        public string LogText { get; set; }
    }
}