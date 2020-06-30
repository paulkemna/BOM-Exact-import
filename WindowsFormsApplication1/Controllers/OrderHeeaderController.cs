using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1.Controllers
{
    // this class get the all the order header files from the database and returns those in an accending order
    class OrderHeeaderController
    {
        // AT ALL TIMES YOU CAN PUT THE CURSOR ON THE CLASS OR METHOD THEN PRESS F12 TO GO TO THE CLASS-DECLARATION.

        List<orkrg> OrderHeaders = new List<orkrg>();
        InduEntities oe = new InduEntities();
        Random randomMonster = new Random();
        List<string> debNrs = new List<string>();
        List<string> orderNrs = new List<string>();

        public List<string> GetdebNrs()
        {
            OrderHeaders = oe.orkrg.OrderByDescending(x => x.ordernr).ToList();
            foreach (var item in OrderHeaders)
            {
                if (item.debnr != null)
                {
                    debNrs.Add(item.debnr);
                }
            }
            return debNrs;
        }

        public List<orkrg> GetAllOrderNr()
        {
            OrderHeaders = oe.orkrg.ToList();
            return OrderHeaders;
        }
    }
}
