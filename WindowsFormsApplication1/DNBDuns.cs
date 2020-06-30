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
    
    public partial class DNBDuns
    {
        public int ID { get; set; }
        public string duns_nbr { get; set; }
        public string package { get; set; }
        public Nullable<System.Guid> cmp_wwn { get; set; }
        public double act_pay { get; set; }
        public double act_rec { get; set; }
        public string adr_line { get; set; }
        public string adr_tenr_type_cd { get; set; }
        public string audt_ind { get; set; }
        public string audt_qlfn_ind { get; set; }
        public double avg_high_cr { get; set; }
        public string br_ind { get; set; }
        public string bus_regn_nbr { get; set; }
        public string bus_regn_nbr_type_cd { get; set; }
        public string bus_stru { get; set; }
        public string capl_amt { get; set; }
        public string capl_crcy_cd { get; set; }
        public string capl_type_cd { get; set; }
        public double cash_liq_aset { get; set; }
        public string ceo_nme { get; set; }
        public string ceo_titl { get; set; }
        public string clm_ind { get; set; }
        public string cngl_dist_cd { get; set; }
        public string cons_ind { get; set; }
        public double cost_of_sls { get; set; }
        public int cr_scr { get; set; }
        public string cr_scr_cmty { get; set; }
        public string crcy_cd { get; set; }
        public string crim_ind { get; set; }
        public string ctry_cd { get; set; }
        public int curr_cntl_yr { get; set; }
        public double curr_rato { get; set; }
        public string davd_ind { get; set; }
        public int dbar_cnt { get; set; }
        public Nullable<System.DateTime> dbar_dt { get; set; }
        public double divd { get; set; }
        public string dnb_ratg { get; set; }
        public string dom_ult_ctry_cd { get; set; }
        public int dom_ult_pnt_duns { get; set; }
        public string dom_ult_pnt_nme { get; set; }
        public string dstr_ind { get; set; }
        public string empl_at_prim_adr { get; set; }
        public string empl_at_prim_adr_estd_ind { get; set; }
        public string empl_at_prim_adr_text { get; set; }
        public string empl_at_prim_adr_min_ind { get; set; }
        public int enq_duns { get; set; }
        public string estd_ind { get; set; }
        public string expt_ind { get; set; }
        public int fail_scr { get; set; }
        public string fail_scr_cmty { get; set; }
        public int fail_scr_natl_pctg { get; set; }
        public string fail_scr_ovrd_cd { get; set; }
        public string fax_nbr { get; set; }
        public string fcst_ind { get; set; }
        public string finl_embt_ind { get; set; }
        public string finl_lgl_evnt_ind { get; set; }
        public string fisc_ind { get; set; }
        public double fixd_aset { get; set; }
        public string fnal_ind { get; set; }
        public string gbl_ult_ctry_cd { get; set; }
        public int gbl_ult_pnt_duns { get; set; }
        public string gbl_ult_pnt_nme { get; set; }
        public string glbl_fail_scr { get; set; }
        public double gros_incm { get; set; }
        public double high_cr { get; set; }
        public string hist_ind { get; set; }
        public string hq_ctry_cd { get; set; }
        public int hq_duns { get; set; }
        public string hq_nme { get; set; }
        public string impt_ind { get; set; }
        public Nullable<System.DateTime> incm_stmt_dt { get; set; }
        public int incn_yr { get; set; }
        public int intl_dlng_cd { get; set; }
        public double itng_aset { get; set; }
        public string lbr_spls_area_ind { get; set; }
        public string lcl_actv_cd { get; set; }
        public string lcl_actv_cd_type { get; set; }
        public string lgl_form { get; set; }
        public string locn_stat { get; set; }
        public double lt_dbt { get; set; }
        public double max_cr { get; set; }
        public string max_cr_crcy_cd { get; set; }
        public string miny_ownd_ind { get; set; }
        public double net_incm { get; set; }
        public double net_wrth { get; set; }
        public string non_post_town { get; set; }
        public string open_ind { get; set; }
        public string oprg_spec_evnt_ind { get; set; }
        public string othr_spec_evnt_ind { get; set; }
        public string out_bus_ind { get; set; }
        public double payd_3_mo_ago { get; set; }
        public double payd_norm { get; set; }
        public double payd_scr { get; set; }
        public double pft_bef_tax { get; set; }
        public string pnt_ctry_cd { get; set; }
        public int pnt_duns { get; set; }
        public string pnt_nme { get; set; }
        public string post_code { get; set; }
        public string post_town { get; set; }
        public double prev_net_wrth { get; set; }
        public double prev_sls { get; set; }
        public Nullable<System.DateTime> prev_stmt_dt { get; set; }
        public double prev_wrkg_capl { get; set; }
        public string prim_geo_area { get; set; }
        public string prim_nme { get; set; }
        public string prim_sic { get; set; }
        public string prim_sic_type_cd { get; set; }
        public string prin_nme { get; set; }
        public string prin_ttl { get; set; }
        public string pro_frma_ind { get; set; }
        public double qk_rato { get; set; }
        public string regn_type { get; set; }
        public string rest_ind { get; set; }
        public double retn_erng { get; set; }
        public string scdy_geo_area { get; set; }
        public string scrd_flng_ind { get; set; }
        public string ser_rat { get; set; }
        public string sgnd_ind { get; set; }
        public double sls { get; set; }
        public string sml_bus_ind { get; set; }
        public string stat { get; set; }
        public double stk { get; set; }
        public string stmt_crcy_cd { get; set; }
        public Nullable<System.DateTime> stmt_dt { get; set; }
        public Nullable<System.DateTime> stmt_from_dt { get; set; }
        public Nullable<System.DateTime> stmt_to_dt { get; set; }
        public int strt_yr { get; set; }
        public string suit_jdgt_ind { get; set; }
        public string tlcm_nbr { get; set; }
        public double tot_aset { get; set; }
        public double tot_curr_aset { get; set; }
        public double tot_curr_liab { get; set; }
        public double tot_empl { get; set; }
        public string tot_empl_estd_ind { get; set; }
        public string tot_empl_ind { get; set; }
        public string tot_empl_min_ind { get; set; }
        public string tot_empl_text { get; set; }
        public double tot_liab { get; set; }
        public double tot_liab_and_eqy { get; set; }
        public double tot_lt_liab { get; set; }
        public double tot_pmt { get; set; }
        public string trdg_styl { get; set; }
        public string trl_bal_ind { get; set; }
        public string ubal_ind { get; set; }
        public string womn_ownd_ind { get; set; }
        public System.DateTime syscreated { get; set; }
        public int syscreator { get; set; }
        public System.DateTime sysmodified { get; set; }
        public int sysmodifier { get; set; }
        public System.Guid sysguid { get; set; }
        public byte[] timestamp { get; set; }
    }
}