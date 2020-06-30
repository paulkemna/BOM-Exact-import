using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Controllers
{
    class DebiteurControler
    {
        // this class gets all debtors and all their information from the database and returns some of the information in an accending order
        // note that not all the information about a debtor is in the same table hence the diferent private lists. 
        // all lists made private for there is specific information to be returned not all of it 
         
       InduEntities oe = new InduEntities();
       
       private List<DivisionDebtors> DivDebtor = new List<DivisionDebtors>();
       private List<cicmpy> cicmpy = new List<cicmpy>();
       private List<cicmpy> DebtorDetails = new List<cicmpy>();
       private List<cicntp> cicntp = new List<cicntp>();
       private List<cicntp> DebtorPersonDetails = new List<cicntp>();
       
        public List<DivisionDebtors> GetAllDivDebtors()
        {
            DivDebtor = oe.DivisionDebtors.ToList();

            return DivDebtor;
        }

        public List<cicntp> GetAllDeptorPersonDetails()
        {
            cicntp = oe.cicntp.ToList();
            foreach (var item in GetAllDebtorDetails())
            {
                foreach (var itemRefined in cicntp)
                {
                    if (itemRefined.cnt_id == item.cnt_id)
                    {
                        DebtorPersonDetails.Add(itemRefined);
                    }
                }
            }
            return DebtorPersonDetails;
        }

        public List<cicmpy> GetAllDebtorDetails()
        {
            cicmpy = oe.cicmpy.ToList();
            
            foreach (var item in GetAllDivDebtors())
            {
                foreach (var item2 in cicmpy)
                {
                    if (item2.debnr == item.Debtor)
                    {
                        DebtorDetails.Add(item2);    
                    }
                }    
            }
            return DebtorDetails;
        }
    }
}
