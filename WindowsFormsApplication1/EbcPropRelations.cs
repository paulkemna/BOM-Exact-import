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
    
    public partial class EbcPropRelations
    {
        public System.Guid PropRelationId { get; set; }
        public Nullable<int> PropRelationStateId { get; set; }
        public Nullable<int> PropRelationTypeId { get; set; }
        public System.Guid CompRelationId { get; set; }
        public Nullable<System.Guid> PropId { get; set; }
        public string PropValue { get; set; }
        public string PropName { get; set; }
        public string PropRelationValue { get; set; }
        public bool Enabled { get; set; }
    
        public virtual EbcComponentRelations EbcComponentRelations { get; set; }
        public virtual EbcPropRelationStates EbcPropRelationStates { get; set; }
        public virtual EbcPropRelationTypes EbcPropRelationTypes { get; set; }
        public virtual EbcProps EbcProps { get; set; }
    }
}
