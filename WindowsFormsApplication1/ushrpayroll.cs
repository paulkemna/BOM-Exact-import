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
    
    public partial class ushrpayroll
    {
        public int ID { get; set; }
        public string type { get; set; }
        public short contract { get; set; }
        public System.DateTime startdate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        public string description { get; set; }
        public string job_title { get; set; }
        public Nullable<System.Guid> DocAttachmentID { get; set; }
        public Nullable<short> PayrollYear { get; set; }
        public int Res_id { get; set; }
        public short period { get; set; }
        public string payment_period { get; set; }
        public string Country { get; set; }
        public string emp_type { get; set; }
        public Nullable<System.DateTime> emp_type_date { get; set; }
        public string workshift { get; set; }
        public Nullable<System.DateTime> adjusted_date { get; set; }
        public string time_indicator { get; set; }
        public string fwt_calculation { get; set; }
        public string fica_code { get; set; }
        public string fui_code { get; set; }
        public string other_tax { get; set; }
        public string motorveh_type { get; set; }
        public double insurance_face_value { get; set; }
        public string eic_status { get; set; }
        public double eic_current_amount { get; set; }
        public string salary_indicator { get; set; }
        public string Marital { get; set; }
        public double Exempts { get; set; }
        public double FWTExtra { get; set; }
        public byte Statutory { get; set; }
        public byte RetirementPlan { get; set; }
        public byte SickPay { get; set; }
        public string Sliptext1 { get; set; }
        public string Sliptext2 { get; set; }
        public string Sliptext3 { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}