using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using WindowsFormsApplication1.Controllers;

namespace WindowsFormsApplication1
{
    class Database
    {
        // AT ALL TIMES YOU CAN PUT THE CURSOR ON THE CLASS OR METHOD THEN PRESS F12 TO GO TO THE CLASS-DECLARATION.

        List<orsrg> orsrgList = new List<orsrg>();

        DebiteurControler DebtorController = new DebiteurControler();
        private InduEntities orderEnteties = new InduEntities();
       
        // this is where i bind data in code since this is not done in the database. firstly to bind data we need to get it. This information is never returned.
        // this information is ONLY used in the back ground the so called unit of works of the entitty framework. 
        private ObservableCollection<orkrg> _orderHeader;
        public ObservableCollection<orkrg> orderHeaderCol
        {
            get
            {
                if (_orderHeader == null)
                {
                    _orderHeader = new ObservableCollection<orkrg>();
                }
                return _orderHeader;
            }
        }

        private ObservableCollection<orsrg> _orderBody;
        public ObservableCollection<orsrg> orderBodyCol  
        {
            get
            {
                if (_orderBody == null)
                {
                    _orderBody = new ObservableCollection<orsrg>();

                }   
                return _orderBody;
            }
        }

        private ObservableCollection<DivisionDebtors>_debtor;
        public ObservableCollection<DivisionDebtors> debtor
        {
            get
            {
                if (_debtor == null)
                {
                    _debtor = new ObservableCollection<DivisionDebtors>();
                }
                return _debtor;
            }
        }

        // here we start the actual binding of data therefore the class type is binding source. The lines of ode below bind the debtor data source to the debtor data

        private BindingSource _debtorBindinSource;
        public BindingSource debtorBindingSource
        {
            get
            {
                if (_debtorBindinSource == null)
                {
                    _debtorBindinSource = new BindingSource();
                    _debtorBindinSource.DataSource = debtor;
                }
                return _debtorBindinSource;
            }
        }

        // these lines of code bind the order header data to the order header since an order header has a debtor the debtor and the order header ar bound to each other
        // the order rows do not need to be bound to this in the same way since they contains the same and more information then the header does about the order. 
        // Which is not the case for the debtor and the order header. 

        private BindingSource _orderHeaderBindingSource;
        public BindingSource orderHeaderBindingSourcer()
        {
            if (_orderHeaderBindingSource == null)
            {
                _orderHeaderBindingSource = new BindingSource(); 
            }
            return _orderHeaderBindingSource;
        }

        // this recieves all the information required to forma an order header which can be read from the xml file and which can be obtained by the DebtorController class
        // and the OrderHeaderController Class. note that some information is harcoded this is the case since the information never changes.
        public void CreateOrderHeader(List<cicntp> cicntp, List<cicmpy> DebtorDetails, string debNr, byte orderAfdracht, string orderNr, string fakDebNr, string verzDebNr,
            string eindDebNr, string refer, string afl_week, byte orderbv_afgd, byte afgehandeld, byte nettoPris, byte inv_in_vv, byte  betaald, 
            DateTime orderDate, DateTime aflDate,  DateTime sysCreated, DateTime sysMod, string docTitle)
        {
            cicmpy singleDebtor = DebtorDetails.SingleOrDefault(x => x.debnr == debNr);
            cicntp singleDebtorPerson = cicntp.FirstOrDefault(x => x.cmp_wwn == singleDebtor.cmp_wwn);

            orkrg nieuwe = new orkrg();
            nieuwe.debnr = debNr;
            nieuwe.ordbv_afdr = orderAfdracht;
            nieuwe.orddat = orderDate;
            nieuwe.afldat = aflDate;
            nieuwe.ordbv_afgd = orderbv_afgd;
            nieuwe.afgehandld = afgehandeld;
            nieuwe.nettoprijs = nettoPris;
            nieuwe.inv_in_vv = inv_in_vv;
            nieuwe.betaald = betaald;
            nieuwe.syscreated = sysCreated;
            nieuwe.sysmodified = sysMod;
            nieuwe.FulfilmentDateInInvoice = "O";

            nieuwe.sysguid = Guid.NewGuid();
            nieuwe.ordernr = orderNr;
            nieuwe.fakdebnr = fakDebNr;
            nieuwe.verzdebnr = verzDebNr;
            nieuwe.einddebnr = eindDebNr;
            nieuwe.refer = refer;
            nieuwe.afl_week = afl_week;
            nieuwe.magcode = "INDU";
            nieuwe.kstplcode = "001CC001";
            nieuwe.ord_soort = "V";
            nieuwe.fiattering = "J";
            nieuwe.btw_code = "21";
            nieuwe.valcode = "EUR";
            nieuwe.betcond = "B3";
            nieuwe.levwijze = "T-03";
            nieuwe.stat_code = "F";
            nieuwe.colli = "0";
            nieuwe.user_id = "Stage-1";
            nieuwe.status = "V";
            nieuwe.type_prod = "N";
            nieuwe.represent_id = 1;
            nieuwe.eca_type = "N";
            nieuwe.calc_meth_pc = "1";
            nieuwe.calc_incl_vat = "N";
            nieuwe.docnumber = docTitle;
            nieuwe.paymentmethod = "B";

            nieuwe.ord_debtor_name = singleDebtor.cmp_name;
            nieuwe.ord_AddressLine1 = singleDebtor.cmp_fadd1;
            nieuwe.ord_PostCode = singleDebtor.cmp_fpc;
            nieuwe.ord_City = singleDebtor.cmp_fcity;
            nieuwe.ord_StateCode = singleDebtor.StateCode;
            nieuwe.ord_landcode = singleDebtor.cmp_fcounty;
            nieuwe.ord_Phone = singleDebtor.cmp_tel;
            nieuwe.ord_contactperson = singleDebtorPerson.FullName;
            nieuwe.ord_predcode = singleDebtorPerson.predcode;
            nieuwe.ord_cnt_job_desc = singleDebtorPerson.cnt_job_desc;
            nieuwe.ord_Initials = singleDebtorPerson.Initials;
            nieuwe.ord_contactemail = singleDebtor.cmp_e_mail;

            nieuwe.del_debtor_name = singleDebtor.cmp_name;
            nieuwe.del_AddressLine1 = singleDebtor.cmp_fadd1;
            nieuwe.del_PostCode = singleDebtor.cmp_fpc;
            nieuwe.del_City = singleDebtor.cmp_fcity;
            nieuwe.del_StateCode = singleDebtor.StateCode;
            nieuwe.del_landcode = singleDebtor.cmp_fcounty;
            nieuwe.del_Phone = singleDebtor.cmp_tel;
            nieuwe.del_contactperson = singleDebtorPerson.FullName;
            nieuwe.del_predcode = singleDebtorPerson.predcode;
            nieuwe.del_cnt_job_desc = singleDebtorPerson.cnt_job_desc;
            nieuwe.del_predcode = singleDebtorPerson.predcode;
            nieuwe.del_Initials = singleDebtorPerson.Initials;
            nieuwe.del_contactemail = singleDebtor.cmp_e_mail;

            nieuwe.inv_debtor_name = singleDebtor.cmp_name;
            nieuwe.inv_AddressLine1 = singleDebtor.cmp_fadd1;
            nieuwe.inv_PostCode = singleDebtor.cmp_fpc;
            nieuwe.inv_City = singleDebtor.cmp_fcity;
            nieuwe.inv_StateCode = singleDebtor.StateCode;
            nieuwe.inv_landcode = singleDebtor.cmp_fcounty;
            nieuwe.inv_Phone = singleDebtor.cmp_tel;
            nieuwe.inv_contactperson = singleDebtorPerson.FullName;
            nieuwe.inv_predcode = singleDebtorPerson.predcode;
            nieuwe.inv_cnt_job_desc = singleDebtorPerson.cnt_job_desc;
            nieuwe.inv_predcode = singleDebtorPerson.predcode;
            nieuwe.inv_Initials = singleDebtorPerson.Initials;
            nieuwe.inv_contactemail = singleDebtor.cmp_e_mail;
            nieuwe.ord_landcode = "NL";

            nieuwe.Approver = 1;
            nieuwe.Approved = DateTime.Now;
            nieuwe.resulttype = "A";
            nieuwe.invoice_method = "F";
            nieuwe.freefield4 = 1;
            nieuwe.freefield5 = 1;
            nieuwe.freefield5 = 1;
            nieuwe.Division = 100;
            nieuwe.syscreator = 1;
            nieuwe.sysmodifier = 1;
            nieuwe.tot_bdr = 50;
            nieuwe.nettoprijs = 1;
            nieuwe.inv_in_vv = 1;
            nieuwe.koers = 1;
            nieuwe.iso_taalcd = "NL";
            nieuwe.iso_taalcd_f = "NL";
            nieuwe.int_vrw = "0";
            nieuwe.ImATA = aflDate;
            nieuwe.ImETA = aflDate;
            nieuwe.ImATD = aflDate;
            nieuwe.IncoTermConfirmPrices = true;
            nieuwe.IncoTermAcknowledgeOrder = true;
            nieuwe.ConfirmedBy = 1;
            nieuwe.SMSServiceActivity = false;
            nieuwe.CSPickITOrderPicker = 0;
            nieuwe.CSPICKITCWLatestTryInService = aflDate;
            nieuwe.CSPICKITLatestTryInService = aflDate;
            nieuwe.CSPickITLockTime = aflDate;
            nieuwe.CSPickITLockResource = 0;
            
            orderEnteties.orkrg.Add(nieuwe);

            try
            {
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name + "\" in state \"" + eve.Entry.State + "\" has the following validation errors:"
                        );
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Value: \"" + eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + "\", Error: \"" + ve.ErrorMessage + "\""
                           );
                    }
                }
            }
            
        }

        // this method  writes the all the obtained information from profile artikles to the order body entitity 
        public void CreateOrderBodyProfiel(string orderNr, string regel, DateTime afldat, string artCode, string oms45, string oms45_f, string magCode, float quantity,
            float esr_aantal, string btw_code, float korting, int syscreator,  float CSRekRegelVal, float CSRekRegelVal2, DateTime sysMod, DateTime sysCreated)
        {
            string[] splitArtCode = artCode.Split('-');
            string[] splitArtCode2 =null;
            if (splitArtCode.Count() >1)
            {
                splitArtCode2 = splitArtCode[1].Split('/');

            }
            string pissOff = splitArtCode[0];

            Items artikel = new Items();
            ItemPrices itemPrices = new ItemPrices();

            artikel = orderEnteties.Items.FirstOrDefault(x => x.ItemCode == pissOff);
            itemPrices = orderEnteties.ItemPrices.FirstOrDefault(x => x.ItemCode == pissOff);

            orsrg nieuwe = new orsrg();

            nieuwe.ordernr = orderNr;
            nieuwe.afldat = afldat;
            nieuwe.regel = regel;
            nieuwe.syscreated = Convert.ToDateTime(afldat);
            nieuwe.artcode = splitArtCode[0];
            nieuwe.oms45 = oms45;
            nieuwe.oms45_f = oms45_f;
            nieuwe.magcode = magCode;
            nieuwe.esr_aantal = Math.Round(esr_aantal, 3);
            nieuwe.btw_code = btw_code;
            nieuwe.korting = Math.Round(korting, 2);
            nieuwe.syscreator = syscreator;
            nieuwe.CSRekregValue00 = Math.Round(CSRekRegelVal );
            nieuwe.CSRekregValue01 = Math.Round(CSRekRegelVal2 / 1000, 3, MidpointRounding.ToEven);
            nieuwe.CSRekregFormulaName = "LENGTE";
            nieuwe.sysmodified = sysMod;
            nieuwe.syscreated = sysCreated;
            nieuwe.sysguid = Guid.NewGuid();

            if (splitArtCode2 != null)
            {
                nieuwe.instruction = splitArtCode2[0];
            }

            nieuwe.ar_soort = "V";
            nieuwe.afl_week = "2";
            nieuwe.prijslijst = "SALESPRICE";
            nieuwe.res_id = 1;

            if (artikel != null)
            {
                nieuwe.unitcode = artikel.PackageDescription;
            }
            
            nieuwe.StatisticalFactor = 0;
            nieuwe.Division = 100;
            nieuwe.sysmodifier = syscreator;
            nieuwe.CSrekregFactor = 1;
            nieuwe.kstplcode = "001CC001";

            if (artikel != null)
            {
                nieuwe.prijs83 = (double)artikel.SalesPackagePrice;
            }
            
            nieuwe.prijs_n = Math.Round(nieuwe.prijs83, 2);
            nieuwe.unitfactor = 1;
            nieuwe.vvp = Math.Round(nieuwe.prijs83 / 2);
            nieuwe.koers = 1;
            nieuwe.bdr_vat_val = 21;
            nieuwe.bdr_vat_val = 21;
            nieuwe.bdr_ev_ed_val =Math.Round(nieuwe.prijs83 );
            nieuwe.bdr_val = Math.Round((nieuwe.bdr_ev_ed_val * 1.21) * nieuwe.esr_aantal, 2);

            nieuwe.CSRekregValue00 = quantity;
            nieuwe.CSRekregValue03 = 0;
            nieuwe.CSRekregValue04 = 0;
            nieuwe.CSRekregValue05 = 0;
            nieuwe.CSRekregValue06 = 0;
            nieuwe.CSRekregValue07 = 0;
            nieuwe.CSRekregValue08 = 0;
            nieuwe.CSRekregValue09 = 0; 
            nieuwe.CSRekregValue10 = 0;

            nieuwe.CSRekregRoundedValue00 = quantity;
            nieuwe.CSRekregRoundedValue01 = Math.Round(nieuwe.esr_aantal / (double)nieuwe.CSRekregRoundedValue00, 3);
            nieuwe.CSRekregRoundedValue02 = 1000;
            nieuwe.CSRekregRoundedValue03 = 0;
            nieuwe.CSRekregRoundedValue04 = 0;
            nieuwe.CSRekregRoundedValue05 = 0;
            nieuwe.CSRekregRoundedValue06 = 0;
            nieuwe.CSRekregRoundedValue07 = 0;
            nieuwe.CSRekregRoundedValue08 = 0;
            nieuwe.CSRekregRoundedValue09 = 0;
            nieuwe.CSRekregRoundedValue10 = 0;
            nieuwe.CSRekregLabelOms00 = "aantal";
            nieuwe.CSRekregLabelOms01 = "lengte";

            nieuwe.CSPickITQtyOrdered = 0;
            nieuwe.CSPickITQuantityPicked = 0;
            nieuwe.CSPickITQuantityCrossDock = 0;
            nieuwe.CSPickITTransferLineID = 0;
            nieuwe.CSPickITCWStatusCWDB = "G";
            nieuwe.CSPickITCWStatusSalesDB = "1";

            nieuwe.IntrastatEnabled = true;


            // uncomment " orderEnteties.orsrg.Add(nieuwe);"  code  bellow and comment the code withing the try domain. in order to recive custum build validation errors 
            // they usualy provide moore information about the error then those build my micriosoft
            try
            {
                // in this domain the code saves the data to a list of order body entitities and later those are written to the database in the SaveChanges() method.

                //   orderEnteties.orsrg.Add(nieuwe);
                orsrgList.Add(nieuwe);
            }
                catch (DbEntityValidationException e)
                {
                // custom build validation errors , this domain is only entered when  orderEnteties.orsrg.Add(nieuwe); is uncommented and orsrgList.Add(nieuwe); is commetned
                // in the try domain.

                foreach (var eve in e.EntityValidationErrors)
                    {
                        MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name + "\" in state \"" + eve.Entry.State + "\" has the following validation errors:");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Value: \"" + eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + "\", Error: \"" + ve.ErrorMessage + "\"");
                        }
                    }
                }
        }

        // this method handles the creation of accesories.
        public void CreateOrderBodyACC(string orderNr, string regel, DateTime afldat, string artCode, string oms45, string oms45_f, string magCode, 
            float esr_aantal, string btw_code, float korting, int syscreator, float CSRekRegelVal, DateTime sysMod, DateTime sysCreated)
        {
            Items artikel = new Items();
            ItemPrices itemPrices = new ItemPrices();
            artikel = orderEnteties.Items.FirstOrDefault(x => x.ItemCode == artCode);
            itemPrices = orderEnteties.ItemPrices.FirstOrDefault(x => x.ItemCode == artCode);
            orsrg nieuwe = new orsrg();

            nieuwe.ordernr = orderNr;
            nieuwe.afldat = afldat;
            nieuwe.regel = regel;
            nieuwe.syscreated = Convert.ToDateTime(afldat);
            nieuwe.artcode = artCode;
            nieuwe.oms45 = oms45;
            nieuwe.oms45_f = oms45_f;
            nieuwe.magcode = magCode;
            nieuwe.esr_aantal = Math.Round(esr_aantal,3);
            nieuwe.btw_code = btw_code;
            nieuwe.korting = Math.Round(korting, 2);
            nieuwe.syscreator = syscreator;
            nieuwe.CSRekregValue00 = Math.Round(CSRekRegelVal, 0);
            nieuwe.sysmodified = sysMod;
            nieuwe.syscreated = sysCreated;
            nieuwe.sysguid = Guid.NewGuid();

            nieuwe.ar_soort = "V";
            nieuwe.afl_week = "21";
            nieuwe.prijslijst = "SALESPRICE";
            nieuwe.res_id = 1;

            if (artikel != null)
            {
                nieuwe.unitcode = artikel.PackageDescription;
            }
            
            nieuwe.StatisticalFactor = 0;
            nieuwe.Division = 100;
            nieuwe.sysmodifier = syscreator;
            nieuwe.CSrekregFactor = 1;
            nieuwe.kstplcode = "001CC001";

            if (artikel != null)
            {
                nieuwe.prijs83 = (double)artikel.SalesPackagePrice;
            }
            
            nieuwe.prijs_n = Math.Round(nieuwe.prijs83 );
            nieuwe.unitfactor = 1;
            nieuwe.vvp = Math.Round(nieuwe.prijs83 / 2);
            nieuwe.koers = 1;
            nieuwe.bdr_vat_val = 21;
            nieuwe.bdr_ev_ed_val = Math.Round(nieuwe.prijs83 );
            nieuwe.bdr_val = Math.Round((nieuwe.bdr_ev_ed_val * 1.21) * nieuwe.esr_aantal, 2);

            nieuwe.CSRekregValue00 = nieuwe.esr_aantal;
            nieuwe.CSRekregValue01 = nieuwe.esr_aantal;
            nieuwe.CSRekregValue02 = 1000;
            nieuwe.CSRekregValue03 = 0;
            nieuwe.CSRekregValue04 = 0;
            nieuwe.CSRekregValue05 = 0;
            nieuwe.CSRekregValue06 = 0;
            nieuwe.CSRekregValue07 = 0;
            nieuwe.CSRekregValue08 = 0;
            nieuwe.CSRekregValue09 = 0;
            nieuwe.CSRekregValue10 = 0;

            nieuwe.CSRekregRoundedValue00 = nieuwe.esr_aantal;
            nieuwe.CSRekregRoundedValue01 = nieuwe.esr_aantal;
            nieuwe.CSRekregRoundedValue02 = 1000;
            nieuwe.CSRekregRoundedValue03 = 0;
            nieuwe.CSRekregRoundedValue04 = 0;
            nieuwe.CSRekregRoundedValue05 = 0;
            nieuwe.CSRekregRoundedValue06 = 0;
            nieuwe.CSRekregRoundedValue07 = 0;
            nieuwe.CSRekregRoundedValue08 = 0;
            nieuwe.CSRekregRoundedValue09 = 0;
            nieuwe.CSRekregRoundedValue10 = 0;
            nieuwe.CSRekregLabelOms00 = "aantal";

            nieuwe.CSPickITQtyOrdered = 0;
            nieuwe.CSPickITQuantityPicked = 0;
            nieuwe.CSPickITQuantityCrossDock = 0;
            nieuwe.CSPickITTransferLineID = 0;
            nieuwe.IntrastatEnabled = true;
            nieuwe.CSPickITCWStatusCWDB = "G";
            nieuwe.CSPickITCWStatusSalesDB = "1";

            // uncomment " orderEnteties.orsrg.Add(nieuwe);"  code  bellow and comment the code withing the try domain. in order to recive custum build validation errors 
            // they usualy provide moore information about the error then those build my micriosoft
            try
            {
                // in this domain the code saves the data to a list of order body entitities and later those are written to the database in the SaveChanges() method.

                //   orderEnteties.orsrg.Add(nieuwe);
                orsrgList.Add(nieuwe);
            }
            catch (DbEntityValidationException e)
            {
                // custom build validation errors , this domain is only entered when  orderEnteties.orsrg.Add(nieuwe); is uncommented and orsrgList.Add(nieuwe); is commetned
                // in the try domain.

                foreach (var eve in e.EntityValidationErrors)
                    {
                        MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name + "\" in state \"" + eve.Entry.State + "\" has the following validation errors:");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Value: \"" + eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + "\", Error: \"" + ve.ErrorMessage + "\"");
                        }
                    }

                }
        }


        // this method handles the creation of the plates. 
        public void CreateOrderBodyPlaat(string orderNr, string regel, DateTime afldat, string artCode, string oms45, string oms45_f, string magCode, float quantity,
            float esr_aantal, string btw_code, float korting, int syscreator, float CSRekRegelVal, float CSRekRegelVal2, float CsRekRegVal3, DateTime sysMod, DateTime sysCreated)
        {
            Items artikel = new Items();
            ItemPrices itemPrices = new ItemPrices();

            itemPrices = orderEnteties.ItemPrices.FirstOrDefault(x=> x.ItemCode == artCode);
            artikel = orderEnteties.Items.FirstOrDefault(x => x.ItemCode == artCode);

            orsrg nieuwe = new orsrg();

            nieuwe.ordernr = orderNr;
            nieuwe.regel = regel;
            nieuwe.afldat = Convert.ToDateTime(afldat);
            nieuwe.syscreated = Convert.ToDateTime(afldat);
            nieuwe.artcode = artCode;
            nieuwe.oms45 = oms45;
            nieuwe.oms45_f = oms45_f;
            nieuwe.magcode = magCode;
       
            nieuwe.btw_code = btw_code;
            nieuwe.korting = Math.Round(korting, 2);
            nieuwe.syscreator = syscreator;
            nieuwe.CSRekregValue00 = Math.Round(CSRekRegelVal );
            nieuwe.CSRekregValue01 = Math.Round(CSRekRegelVal2 * 1000 , 3, MidpointRounding.ToEven);
            nieuwe.CSRekregValue02 = Math.Round(CsRekRegVal3 * 1000 , 3, MidpointRounding.ToEven);
            nieuwe.CSRekregFormulaName = "OPPERVLAK";
            nieuwe.sysmodified = sysMod;
            nieuwe.syscreated = sysCreated;
            nieuwe.sysguid = Guid.NewGuid();

            nieuwe.ar_soort = "I";
            nieuwe.afl_week = "21";
            nieuwe.prijslijst = "SALESPRICE";
            nieuwe.res_id = 1;

            if (artikel != null )
            {
                nieuwe.unitcode = artikel.PackageDescription;
            }
            
            nieuwe.StatisticalFactor = 0;
            nieuwe.Division = 100;
            nieuwe.sysmodifier = syscreator;
            nieuwe.CSrekregFactor = 1;
            nieuwe.kstplcode = "001CC001";

            if (artikel != null)
            {
                nieuwe.prijs83 = Math.Round((double)artikel.SalesPackagePrice, 2);
            }
            
            nieuwe.prijs_n = Math.Round(nieuwe.prijs83, 2);
            nieuwe.unitfactor = 1;
            nieuwe.vvp = Math.Round(nieuwe.prijs83 / 2);
            nieuwe.koers = 1;
            nieuwe.bdr_vat_val = 21;
            nieuwe.bdr_ev_ed_val = nieuwe.prijs83;
            nieuwe.bdr_val = Math.Round((nieuwe.bdr_ev_ed_val * 1.21 ) * esr_aantal, 2);

            nieuwe.CSRekregValue03 = 0;
            nieuwe.CSRekregValue04 = 0;
            nieuwe.CSRekregValue05 = 0;
            nieuwe.CSRekregValue06 = 0;
            nieuwe.CSRekregValue07 = 0;
            nieuwe.CSRekregValue08 = 0;
            nieuwe.CSRekregValue09 = 0;
            nieuwe.CSRekregValue10 = 0;
            nieuwe.esr_aantal = Math.Round((double)(nieuwe.CSRekregValue00 * nieuwe.CSRekregValue01 * nieuwe.CSRekregValue02), 3);

            nieuwe.CSRekregRoundedValue00 = quantity;
            nieuwe.CSRekregRoundedValue01 = Math.Round((CSRekRegelVal2 * 1000) / (double)nieuwe.CSRekregRoundedValue00);
            nieuwe.CSRekregRoundedValue02 = Math.Round((CsRekRegVal3 * 1000) / (double)nieuwe.CSRekregRoundedValue00);
            nieuwe.CSRekregRoundedValue03 = 0;
            nieuwe.CSRekregRoundedValue04 = 0;
            nieuwe.CSRekregRoundedValue05 = 0;
            nieuwe.CSRekregRoundedValue06 = 0;
            nieuwe.CSRekregRoundedValue07 = 0;
            nieuwe.CSRekregRoundedValue08 = 0;
            nieuwe.CSRekregRoundedValue09 = 0;
            nieuwe.CSRekregRoundedValue10 = 0;
            nieuwe.CSRekregLabelOms00 = "aantal";
            nieuwe.CSRekregLabelOms01 = "lengte";
            nieuwe.CSRekregLabelOms02 = "breedte";

            nieuwe.CSPickITQtyOrdered = 0;
            nieuwe.CSPickITQuantityPicked = 0;
            nieuwe.CSPickITQuantityCrossDock = 0;
            nieuwe.CSPickITTransferLineID = 0;
            nieuwe.IntrastatEnabled = true;
            nieuwe.CSPickITCWStatusCWDB = "G";
            nieuwe.CSPickITCWStatusSalesDB = "1";

            // uncomment " orderEnteties.orsrg.Add(nieuwe);"  code  bellow and comment the code withing the try domain. in order to recive custum build validation errors 
            // they usualy provide moore information about the error then those build my micriosoft
            try
            {
                // in this domain the code saves the data to a list of order body entitities and later those are written to the database in the SaveChanges() method.

                //   orderEnteties.orsrg.Add(nieuwe);
                orsrgList.Add(nieuwe);
            }
            catch (DbEntityValidationException e)
            {
                // custom build validation errors , this domain is only entered when  orderEnteties.orsrg.Add(nieuwe); is uncommented and orsrgList.Add(nieuwe); is commetned
                // in the try domain.

                foreach (var eve in e.EntityValidationErrors)
                    {
                        MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name + "\" in state \"" + eve.Entry.State + "\" has the following validation errors:");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Value: \"" + eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + "\", Error: \"" + ve.ErrorMessage + "\"");
                        }
                    }
                }
        }

        // This method handles the sublines and their creation.
        public void CreateSubLines(string orderNr, string subRegel, string subArtCode, string subOms45 )
        {
            orsrg nieuwe = new orsrg()
                ;
            nieuwe.ordernr = orderNr;
            nieuwe.afldat = DateTime.Now;
            nieuwe.regel = subRegel;
            nieuwe.syscreated = Convert.ToDateTime(DateTime.Now);
            nieuwe.artcode = null;
            nieuwe.oms45 = subArtCode;
            nieuwe.oms45_f ="SubRegel";
            nieuwe.magcode = "INDU";
            nieuwe.esr_aantal = 0;
            nieuwe.btw_code = "21";
            nieuwe.korting = 0;
            nieuwe.syscreator = 1;
            nieuwe.CSRekregValue00 = 0;
            nieuwe.sysmodified = DateTime.Now;
            nieuwe.syscreated = DateTime.Now;
            nieuwe.sysguid = Guid.NewGuid();
            nieuwe.instruction = subOms45;

            nieuwe.ar_soort = "T";
            nieuwe.afl_week = "21";
            nieuwe.prijslijst = "";
            nieuwe.res_id = 1;

            nieuwe.unitcode = "";
            
            nieuwe.StatisticalFactor = 0;
            nieuwe.Division = 100;
            nieuwe.sysmodifier = 1;
            nieuwe.CSrekregFactor = 1;
            nieuwe.kstplcode = "001CC001";
            nieuwe.prijs83 = 0;
            

            nieuwe.prijs_n = Math.Round(nieuwe.prijs83);
            nieuwe.unitfactor = 1;
            nieuwe.vvp = Math.Round(nieuwe.prijs83 / 2);
            nieuwe.koers = 1;
            nieuwe.bdr_vat_val = 21;
            nieuwe.bdr_ev_ed_val = Math.Round(nieuwe.prijs83);
            nieuwe.bdr_val = Math.Round((nieuwe.bdr_ev_ed_val * 1.21) * nieuwe.esr_aantal, 2);

            nieuwe.CSRekregValue00 = nieuwe.esr_aantal;
            nieuwe.CSRekregValue01 = nieuwe.esr_aantal;
            nieuwe.CSRekregValue02 = 1000;
            nieuwe.CSRekregValue03 = 0;
            nieuwe.CSRekregValue04 = 0;
            nieuwe.CSRekregValue05 = 0;
            nieuwe.CSRekregValue06 = 0;
            nieuwe.CSRekregValue07 = 0;
            nieuwe.CSRekregValue08 = 0;
            nieuwe.CSRekregValue09 = 0;
            nieuwe.CSRekregValue10 = 0;

            nieuwe.CSRekregRoundedValue00 = nieuwe.esr_aantal;
            nieuwe.CSRekregRoundedValue01 = nieuwe.esr_aantal;
            nieuwe.CSRekregRoundedValue02 = 1000;
            nieuwe.CSRekregRoundedValue03 = 0;
            nieuwe.CSRekregRoundedValue04 = 0;
            nieuwe.CSRekregRoundedValue05 = 0;
            nieuwe.CSRekregRoundedValue06 = 0;
            nieuwe.CSRekregRoundedValue07 = 0;
            nieuwe.CSRekregRoundedValue08 = 0;
            nieuwe.CSRekregRoundedValue09 = 0;
            nieuwe.CSRekregRoundedValue10 = 0;
            nieuwe.CSRekregLabelOms00 = "aantal";

            nieuwe.CSPickITQtyOrdered = 0;
            nieuwe.CSPickITQuantityPicked = 0;
            nieuwe.CSPickITQuantityCrossDock = 0;
            nieuwe.CSPickITTransferLineID = 0;
            nieuwe.IntrastatEnabled = true;
            nieuwe.CSPickITCWStatusCWDB = "G";
            nieuwe.CSPickITCWStatusSalesDB = "1";

            // uncomment " orderEnteties.orsrg.Add(nieuwe);"  code  bellow and comment the code withing the try domain. in order to recive custum build validation errors 
            // they usualy provide moore information about the error then those build my micriosoft
            try
            {
                // in this domain the code saves the data to a list of order body entitities and later those are written to the database in the SaveChanges() method.

                //   orderEnteties.orsrg.Add(nieuwe);
                orsrgList.Add(nieuwe);
            }
            catch (DbEntityValidationException e)
            {
                // custom build validation errors , this domain is only entered when  orderEnteties.orsrg.Add(nieuwe); is uncommented and orsrgList.Add(nieuwe); is commetned
                // in the try domain.

                foreach (var eve in e.EntityValidationErrors)
                {
                    MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name + "\" in state \"" + eve.Entry.State + "\" has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Value: \"" + eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + "\", Error: \"" + ve.ErrorMessage + "\"");
                    }
                }

            }
        }
            
        // The final step is to save data to the database this method savee all the order bodies in the orsrg list to the database for each in it. This is done one by one.
        public void SaveOrder()
        {
            foreach (var orsg in orsrgList)
            {
                orsrg addOrsrg = new orsrg();
                addOrsrg = orsg;
                orderEnteties.orsrg.Add(addOrsrg);
                SaveChanges();
     
            }
        }

        // The refresh all method refreshes all entries to the database and reloads those. This method makes the program extreemly slow but makes sure the entry is alwasys 
        // correct. Currently not used, to use when you debug with an xml file that does not contain more then 15 lines.

        public void RefreshAll()
        {
            foreach (var entity in orderEnteties.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        private void SaveChanges()
        {
            StringBuilder sb = new StringBuilder();
           
            try
            {
                orderEnteties.SaveChanges();
                
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException upex)
            {
                sb.AppendLine("DB-Update Errors:");
                Exception inner = upex.InnerException;

                while (inner != null)
                {
                    sb.AppendLine(inner.Message);
                    inner = inner.InnerException;        
                }
            }

            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);  MessageBox.Show(sb.ToString());
            }
          //  RefreshAll();
        }
    }
}
