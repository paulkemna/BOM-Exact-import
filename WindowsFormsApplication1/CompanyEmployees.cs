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
    
    public partial class CompanyEmployees
    {
        public System.Guid ID { get; set; }
        public string CompanyCode { get; set; }
        public string ScenarioCode { get; set; }
        public int FinYear { get; set; }
        public int FinPeriod { get; set; }
        public string CostcenterCode { get; set; }
        public Nullable<int> EmployeesCount { get; set; }
        public Nullable<double> EmployeesFTE { get; set; }
        public Nullable<double> EmployeesBudget { get; set; }
        public Nullable<short> Division { get; set; }
        public byte[] timestamp { get; set; }
    }
}