using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.Controllers;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        string sFileName;
        Database db = new Database();
        BomXmlReader Reader = new BomXmlReader();
        OrderHeeaderController HeaderController = new OrderHeeaderController();
        DebiteurControler DebtorController = new DebiteurControler();
        public List<cicmpy> DebtorDetails = new List<cicmpy>();
        public List<cicntp> cicntp = new List<cicntp>();
       
        public Form1()
        {
            InitializeComponent();
        }
        
        // this happends when the form loads and the application starts. in this method the code gets all the information of the debtors 
        // in order to form orders and select debtors
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in DebtorController.GetAllDebtorDetails())
            {
                DebtorDetails.Add(item);
            }

            foreach (var item in DebtorController.GetAllDeptorPersonDetails())
            {
                cicntp.Add(item);
            }
            cmbDebtorComp.DataSource = DebtorDetails;
            cmbDebtorComp.DisplayMember = "cmp_name";
        }

        private void btnChooseDebtor_Click(object sender, EventArgs e)
        {
            ConvertToExactXml Converter = new ConvertToExactXml();

            Converter.BomToSql(lblDebNr.Text, cicntp, DebtorDetails, txtReferentie.Text, txtOmschrijving.Text, dtpLeverdatum.Value);
        }

        // this is an evetn isntead if a method. an event acures when certain actions come to pass and based on those actions  a reaction from the code follows
        // For this event you select a debtor and the debtor number is displayed bellow the debtor selection. This is needed to send the debtorNr to the bind
        // the orders to the debtors.
        private void cmbDebtorComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in DebtorDetails)
	        {
                if(item.cmp_name == cmbDebtorComp.Text)
                {
                    lblDebNr.Text = item.debnr; 
                }
            }
        }
    }
}