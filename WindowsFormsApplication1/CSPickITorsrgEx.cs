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
    
    public partial class CSPickITorsrgEx
    {
        public int ID { get; set; }
        public string OrderNumber { get; set; }
        public string ItemCode { get; set; }
        public string Warehouse { get; set; }
        public string HandTerminalID { get; set; }
        public Nullable<int> OrderPicker { get; set; }
        public string PickITState { get; set; }
        public Nullable<double> QuantityPicked { get; set; }
        public Nullable<System.Guid> TransactionGUID { get; set; }
        public byte uitgifte { get; set; }
        public string CSPickITShipmentSSCC { get; set; }
        public byte AddToOrder { get; set; }
        public byte ZeroAmount { get; set; }
        public byte ModifyQuantity { get; set; }
        public double UnitFactor { get; set; }
        public string UnitCode { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> RecipeQuantity { get; set; }
        public int RecipeID { get; set; }
        public string Version { get; set; }
        public Nullable<int> ExplodeSequenceNumber { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.Guid> ExplodeMainOrsrgExGUID { get; set; }
        public Nullable<int> TransferLineID { get; set; }
        public Nullable<System.Guid> PreCollectionGUID { get; set; }
        public Nullable<double> LinkedQtyReceived { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
        public byte IsTransfered { get; set; }
    }
}