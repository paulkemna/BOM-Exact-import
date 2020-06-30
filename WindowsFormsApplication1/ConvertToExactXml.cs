using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using WindowsFormsApplication1.Controllers;

namespace WindowsFormsApplication1
{
    // AT ALL TIMES YOU CAN PUT THE CURSOR ON THE CLASS OR METHOD THEN PRESS F12 TO GO TO THE CLASS-DECLARATION.

    // This class gets the file path of a file and converts it into a byte array which it writes to an xml for further explenation i have created more coments for all the methods in this class. 
    class ConvertToExactXml
    {
        // Declaring  variables and classe for later use.
         SaveFileDialog sfd = new SaveFileDialog();
        BomXmlReader BomxmlReader = new BomXmlReader();
        Database Db = new Database();
        OrderHeeaderController orderHeeaderController = new OrderHeeaderController();
        bool isSubRegel = false;
        int counter;
        int y = 0;
        int z = 0;
        int artCounter = 0;
        int plaatRekenCounter = 0;
        int profileRekenCounter = 0;
        int plaatCounter = 0;
        int itemCounter = 0;
        int profileCounter = 0;
        int regelCount = 0;
        List<string> ArtikelCodes = new List<string>();
        List<string> isPlaat = new List<string>();
        List<string> isProfile = new List<string>();
        List<string> rawBody = new List<string>();
        List<string> BomXml = new List<string>();
        List<string> itemCode = new List<string>();
        List<double> rekenRegelsProfiel = new List<double>();
        List<double> rekenRegelsPlaat = new List<double>();
        List<orkrg> orkrgs = new List<orkrg>();
        List<string> orderNrs = new List<string>();

        List<string> refinedBody = new List<string>();

        //--------------------------------------------------SNOWFLAKE HANDLER PARAMS-------------------------------------------------------
        List<string> snowflakes = new List<string>();
        List<string> snowflakeRgel = new List<string>();
        List<string> snowflakeArtCode = new List<string>();
        List<string> snowflakeOms45 = new List<string>();  
        int specialCounter = 0;
        //--------------------------------------------------SNOWFLAKE HANDLER PARAMS-------------------------------------------------------


        //-------------------------------------------------Database gegevens profiel--------------------------------------------------------------- 
        List<string> orderNrProfiel = new List<string>();
        List<string> regelProfiel = new List<string>();                // wordt gevuld
        List<DateTime> afldatProfiel = new List<DateTime>();           // nullable
        List<string> artCodeProfiel = new List<string>();              // wordt gevuld
        List<string> oms45Profiel = new List<string>();                // wordt geculd 
        List<string> oms45_fProfiel = new List<string>();              // niet echt nodig
        float magCodeProfiel = 1;                                      // Altijd INDU
        List<float> esr_aantalProfiel = new List<float>();             // wordt gevuld 
        List<float> esr_aantalProfiel2 = new List<float>();            // wordt gevuld 
        List<string> btw_codeProfiel = new List<string>();             // altijd 19 of null 
        List<string> prijslijstProfiel = new List<string>();           // nullable of SALESPRICE of lengte of zak moet nog wordern gevuld 
        List<int> syscreatorProfiel = new List<int>();                 // altijd 1
        List<float> CSRekRegelValProfiel = new List<float>();          // wordt gevuld 
        List<float> CSRekRegelVal2Profiel = new List<float>();         // wordt gevuld 
        List<float> CSRekRegelVal3Profiel = new List<float>();         // wordt gevuld 
        List<string> CSFormulaNameProfiel = new List<string>();        // wordt gevuld
        DateTime sysMod = new DateTime();                       // Altijd Vandaag
      
 //-------------------------------------------------Database gegevens profiel--------------------------------------------------------------- 

 //-------------------------------------------------Database gegevens plaat--------------------------------------------------------------- 
        List<string> orderNrPlaat = new List<string>();
        List<string> regePlaatl = new List<string>();                // wordt gevuld
        List<DateTime> afldatPlaat = new List<DateTime>();           // nullable
        List<string> artCodePlaat = new List<string>();              // wordt gevuld
        List<string> oms45Plaat = new List<string>();                // wordt geculd 
        List<string> oms45_fPlaat = new List<string>();              // niet echt nodig
        float magCodePlaat = 1;                                      // Altijd INDU
        List<float> esr_aantalPlaat = new List<float>();             // wordt gevuld 
        List<float> esr_aantalPlaat2 = new List<float>();             // wordt gevuld 
        List<string> btw_codePlaat = new List<string>();             // altijd 19 of null 
        List<string> prijslijstPlaat = new List<string>();           // nullable of SALESPRICE of lengte of zak moet nog wordern gevuld 
        List<int> syscreatorPlaat = new List<int>();                 // altijd 1
        List<float> CSRekRegelValPlaat = new List<float>();          // wordt gevuld 
        List<float> CSRekRegelVal2Plaat = new List<float>();         // wordt gevuld 
        List<float> CSRekRegelVal3Plaat = new List<float>();         // wordt gevuld 
        List<string> CSFormulaNamePlaat = new List<string>();        // wordt gevuld

 //-------------------------------------------------Database gegevens plaat---------------------------------------------------------------

 //-------------------------------------------------Database gegevens ACC----------------------------------------------------------------- 
        List<string> orderNr = new List<string>();
        List<string> regel = new List<string>();                // wordt gevuld
        List<DateTime> afldat = new List<DateTime>();           // nullable
        List<string> artCode = new List<string>();              // wordt gevuld
        List<string> oms45 = new List<string>();                // wordt geculd 
        List<string> oms45_f = new List<string>();              // niet echt nodig
        float magCode = 1;                                      // Altijd INDU
        List<float> esr_aantal = new List<float>();
        List<float> esr_aantal2 = new List<float>();                                                        // wordt gevuld 
        List<string> btw_code = new List<string>();             // altijd 19 of null 
        List<string> prijslijst = new List<string>();           // nullable of SALESPRICE of lengte of zak moet nog wordern gevuld 
        List<int> syscreator = new List<int>();                 // altijd 1
        List<float> CSRekRegelVal = new List<float>();          // wordt gevuld 
        List<float> CSRekRegelVal2 = new List<float>();         // wordt gevuld 
        List<float> CSRekRegelVal3 = new List<float>();         // wordt gevuld 
 //-------------------------------------------------Database gegevens ACC-----------------------------------------------------------------
        
        // Returns a list of xml itmes
        public List<string> XmlHeader()
        {
            List<string> header = new List<string>();
            header.Add("<?xml version =" + '"' + "1.0" + '"' + "?> ");
            header.Add("<eExact xmlns:xsi=" + '"' + "http://www.w3.org/2001/XMLSchema-instance " + '"' + " xsi:noNamespaceSchemaLocation=" + '"' + "eExact-Schema.xsd" +  '"' + "> ");
            header.Add("<Orders> ");
            header.Add("<Order type=" + '"' + "B" + '"' + " number=" + '"' + "00000001" + '"' + "> ");
            header.Add("<Description>Test</Description>");
            header.Add("<OurRef>0</OurRef>");
            header.Add("<Currency code=" + '"' + "EUR" + '"' + "/>");
            header.Add("<OrderedAt>");                        
            header.Add("<Creditor code=" + '"' + "26003" + '"' + " number=" + '"' + "26003" + '"' + " type=" + '"' + "S" + '"' + ">");
            header.Add("</Creditor>");
            header.Add("</OrderedAt>");
            header.Add("<DeliverTo>");
            header.Add("<Warehouse code=" + '"' + "INDU" + '"' + ">");
            header.Add("</Warehouse>");
            header.Add("</DeliverTo>");
            header.Add("<InvoiceTo>"); 
            header.Add("<Warehouse code=" + '"' + "INDU" + '"' + ">");
            header.Add("</Warehouse>");
            header.Add("<Address>");
            header.Add("<Addressee>");
            header.Add("<Name>Paul Kemna</Name>");
            header.Add("<Initials>PGBHM</Initials>");
            header.Add("<Title code=" + '"' + "MR"  + '"' + " />");
            header.Add("<JobDescription>DIR DIV</JobDescription>");
            header.Add("</Addressee>");
            header.Add("<AddressLine1>Wassenaarweg 12</AddressLine1>");
            header.Add("<PostalCode>7021 PA</PostalCode>");
            header.Add("<City>Zelhem</City>");
            header.Add("<State code=" + '"' + "GL" + '"' + "/>");
            header.Add("<Country code=" + '"' + "NL" + '"' + "/>");
            header.Add("</Address>");
            header.Add("</InvoiceTo>");
            header.Add("<PaymentMethod code=" + '"' + "B " + '"' + "/>");
            header.Add("<DeliveryMethod code=" + '"' + "T-13" + '"' + " type=" + '"' + "N" + '"' + ">");
            header.Add("</DeliveryMethod>");
            header.Add("<PurchaseOrderMethod code=" + '"' + "EM" + '"' + ">");
            header.Add("</PurchaseOrderMethod>");

            // put the cursor on the method and click ont it then press f12 to got to the declaration of the method/ class .Further explenation of thje class will follow there.  method  = XmlBody() in the foreach loop
            // this specific loop gets the inner xml and adds it to the header that is to be written the xml is also used in other classes to for the data which is later written to the database 

            foreach (var item in XmlBody())
	        {
		        header.Add(item);
	        }
            header.Add("</Order>");
            header.Add("</Orders>");
            header.Add("</eExact>");
     
            return header;
        }


        //  Method for refining the raw xml body from a BOM file
        public List<string> XmlBody()
        {
            // within this foreach loop the code gets the name of the xml node and which it gets from the GetXml method then it refines the xml and put data in the lists and arrays to write those to the database later on. 
            // the lsits are defined above as a global variable which means that those can be used in this whole class witouth the restriction of being define within a method yet an other time
            // the restriction of the datatyye e.g <string> is still there and eny data entering the list should be formated to it.
            // The arrays are defined in the BomtoSql method this is done to add an extra protection layer on their data since
            // it should be finalized there and be unable to be changed or accesed outside eny other method than the method which writes it to the sql server

            string subString;
            int start;
            int end;
            int i = 0;
            int i2 = 0;
            string element;

            // put the cursor on the method and click ont it then press f12 to got to the declaration of the method/ class .Further explenation of thje class will follow there. method = GetXml()
            // getting the xml from the BOM file using the BOM-XML-Reader. By prosesing it trough a loop which filters out the wrong tags and elements and replaces them with the required once for exact. Finely putting them into a raw xml list
            foreach (var item in BomxmlReader.GetXml())
            {
              
                if (item.Contains("<tag>"))

                {
                    // when the xml node name tag is found the code enters this domein. Here the code defines if the specific entering line is a sub line of a main line
                    // e.g 1.a is a sub line for one and should be handled diferantly by the snowFlake handler. The name is deu to the fact that this handler does not
                    // have a price for each and does not break the code for those are written in the database in a special order in a special loop. 
                    // snowFlake handler is not a class it is a special code structure which handles exceptions as if those are not one and just normal data.

                    regelCount++;
                    
                    element = item.Substring(item.IndexOf("<") + 1, item.IndexOf(">") - 1);
                    start = item.IndexOf(">");
                    end = item.IndexOf("</" + element + ">");
                    subString = item.Substring(start + 1, end - 5);

                    
                    if (item.Contains("."))
                    {
                        snowflakeRgel.Add(subString);
                        specialCounter++;
                        isSubRegel = true;
                    }
                    else
                    {
                        itemCounter++;
                        rawBody.Add(String.Format("<OrderLine lineNo={0}{1}{2}>", '"', subString, '"'));
                        regel.Add(subString);
                        isSubRegel = false;
                    }
                }

                if (item.Contains("<description>"))
                {

                    // When code enter this domein the code hhas define a node to be a description node. mainly the most importan node for carbon-plates. In here it indeed checks
                    // wether an item is a plate a profile or an accesoire. In the case it is a plate the description is broken down in small parts so that the code can read
                    // the plates measurement and start the calculation. Also so that those measurments can be written to the databasr in the RekRegValue fields.

                    element = item.Substring(item.IndexOf("<") + 1, item.IndexOf(">") - 1);
                    start = item.IndexOf(">");
                    end = item.IndexOf("</" + element + ">");
                    subString = item.Substring(start + 1, end - 13);

                    if (isSubRegel == true)
                    {
                        snowflakeOms45.Add(subString);
                        isSubRegel = true;
                    }

                    else
                    {
                        itemCounter++;

                        rawBody.Add(String.Format("<Description>{0}</Description>", subString));
                        string[] splitString = subString.Split(',');
                        oms45.Add(splitString[0]);

                        if (item.Contains("SIZE"))
                        {
                            isPlaat.Add(String.Format("<Description>{0}</Description>", subString));
                            start = item.IndexOf("SIZE:");
                            end = item.IndexOf("*");
                            subString = item.Substring(start, end - 31);
                            string[] splitStr = subString.Split('x');
                            subString = splitStr[0].Substring(0, splitStr[0].IndexOf("M"));
                            if (subString.Contains("SIZE"))
                            {
                                string[] splitStr2 = subString.Split(':');
                                rekenRegelsPlaat.Add(Convert.ToDouble(splitStr2[1]) / 100000000);
                                CSRekRegelVal2Plaat.Add(float.Parse(splitStr2[1]) / 100000000);
                                CSFormulaNamePlaat.Add("OPPERVLAKTE");
                                plaatCounter++;
                                plaatRekenCounter++;
                            }
                            subString = splitStr[1].Substring(0, splitStr[1].IndexOf("M"));
                            CSRekRegelVal3Plaat.Add(float.Parse(subString) / 100000000);
                            rekenRegelsPlaat.Add(Convert.ToDouble(subString) / 10000000);
                        }
                        if (item.Contains("Profile") || item.Contains("profile"))
                        {
                            profileCounter++;
                            
                        }
                        isSubRegel = false;
                    }
                }

                if (item.Contains("<article>"))
                {
                    // when the code enters this domein it has defined a xml node to be an article . Here the code breaks down the valeu of the article. This part is especialy
                    // importan for profiles since the measurment of the profiles is defined in that valeu the procedure is semiliar to the discription domein. Also in this
                    // domein the article code is saved in a list and used in the database class to find the data such as formula and cost matching the specific afticle.

                    artCounter++;
                    element = item.Substring(item.IndexOf("<") + 1, item.IndexOf(">") - 1);
                    start = item.IndexOf(">");
                    end = item.IndexOf("</" + element + ">");
                    subString = item.Substring(start + 1, end - 9);

                    if (isSubRegel == true)
                    {
                        snowflakeArtCode.Add(subString);
                        isSubRegel = true;
                    }

                    else
                    {
                        itemCounter++;
                        artCode.Add(subString);

                        string[] splitStr = subString.Split('-');
                        rawBody.Add(String.Format("<Item code={0}{1}{2}>" + "</Item>", '"', splitStr[0], '"'));
                        itemCode.Add("<ItemCode>" + splitStr[0] + "</ItemCode>");
                        ArtikelCodes.Add(subString);
                        CSFormulaNameProfiel.Add("LENGTE");

                        if (subString.Contains("/"))
                        {
                            isProfile.Add(String.Format("<Item code={0}{1}{2}>" + "</Item>", '"', splitStr[0], '"'));
                            splitStr = subString.Split('/');
                            if (splitStr[1].Contains("."))
                            {
                                double r1 = Convert.ToDouble(splitStr[1]);
                                double r2 = Math.Round(r1 / 10, 0);
                                rekenRegelsProfiel.Add(r2);
                                CSRekRegelVal2Profiel.Add((float)r2);
                                profileRekenCounter++;
                            }
                            else
                            {
                                rekenRegelsProfiel.Add(Convert.ToDouble(splitStr[1]));
                                CSRekRegelVal2Profiel.Add(float.Parse(splitStr[1]));
                                profileRekenCounter++;
                            }
                        }
                        isSubRegel = false;
                    }
                }

                if (item.Contains("<quantity>"))
                {
                    // This domein is important for each node and arcticle since this is alwasy the last domein for the code to enter.
                    // Having the information from all the previouse domeins the code here can calculate the total amount and measurments of all products.
                    double uitkokmst = 0;
                    string[] rawBodyArr = rawBody.ToArray();
                    element = item.Substring(item.IndexOf("<") + 1, item.IndexOf(">") - 1);
                    start = item.IndexOf(">");
                    end = item.IndexOf("</" + element + ">");
                    subString = item.Substring(start + 1, end - 10);

                    if (isSubRegel)
                    {
                        // Only define subline as true, for the erest do nothing these kind of lines are only text artikles
                        isSubRegel = true;
                    }

                    else
                    {
                        itemCounter++;
                        isSubRegel = false;
                        try
                        {
                            foreach (var item2 in rawBody)
                            {
                                if (y != plaatCounter && item2.Contains("SIZE") && item2 == isPlaat[plaatCounter - 1])
                                {
                                    for (int r = 0; r < Convert.ToInt16(subString); r++)
                                    {
                                        uitkokmst = uitkokmst + (rekenRegelsPlaat[plaatRekenCounter - 1] * rekenRegelsPlaat[plaatRekenCounter]);
                                    }
                                    string quantity = "<Quantity>" + uitkokmst.ToString().Replace(",", ".") + "</Quantity>";
                                    rawBody.Add(quantity);
                                    CSRekRegelValPlaat.Add(float.Parse(subString));
                                    esr_aantal.Add(float.Parse(uitkokmst.ToString()));
                                    esr_aantal2.Add(float.Parse(subString.ToString()));
                                    plaatRekenCounter++;
                                    y++;
                                }

                                if (item2.Contains("<Item code=") && z != profileCounter && item2 == isProfile[profileRekenCounter - 1])
                                {
                                    for (int a = 0; a < Convert.ToInt16(subString); a++)
                                    {
                                        uitkokmst = uitkokmst + Math.Round(((rekenRegelsProfiel[profileRekenCounter - 1])) / 1000, 3);
                                    }

                                    string quantity = "<Quantity>" + uitkokmst.ToString().Replace(",", ".") + "</Quantity>";
                                    esr_aantal.Add(float.Parse(uitkokmst.ToString()));
                                    esr_aantal2.Add(float.Parse(subString.ToString()));
                                    rawBody.Add(quantity);
                                    CSRekRegelValProfiel.Add(float.Parse(subString));

                                    z++;
                                }
                            }
                        }

                        catch (Exception)
                        {
                            // DO NOT UNDER ENY CIRCUMSTANSES DELETE THIS CATCH EVEN IF THERE IS NOTHING IN HERE YOU CAN PLACE CODE HERE BUT THERE IS NO NEED TO
                            // THIS CATCH IS PART OF THE SNOFLAKE-HANDLER
                        }

                        if (itemCounter == (rawBody.Count + 1))
                        {
                            rawBody.Add("<Quantity>" + subString + "</Quantity>");
                            CSRekRegelVal.Add(float.Parse(subString));
                            esr_aantal.Add(float.Parse(subString.ToString(), CultureInfo.InvariantCulture.NumberFormat));
                        }
                    }
                }
            }
            
            // Refining the raw list by adding the right tag and elements into the right place of thee refined-xml-body list. 
            // Counting the amount of items 

            isSubRegel = false;
            while (rawBody.Count() > i)
            {
                // takes the modulo of the amount of time the code has ran trough the loop. By doing so defining in which order the xml file should be written

                int x = i % 4;
      
                rawBody.ToArray();

                if (rawBody[i].Contains("OrderLine lineNo=") && rawBody[i].Contains("."))
                {
                    isSubRegel = true;
                }

               
                else
                {
                    // 0 is the order line number
                    if (x == 0)
                    {
                        refinedBody.Add(rawBody[0 + i]);
                    }
                    // 1 is the discription
                    if (x == 1)
                    {
                        if (i > 1)
                        {
                            refinedBody.Add(rawBody[2 + (i - 1)]);
                        }
                        else { refinedBody.Add(rawBody[2]); }
                    }
                    // 2 is the aticle number
                    if (x == 2)
                    {
                        if (i > 2)
                        {
                            refinedBody.Add(rawBody[1 + (i - 2)]);
                        }
                        else { refinedBody.Add(rawBody[1]); }
                    }

                    if (x == 3)
                    {
                        if (i > 3)
                        {
                            //3 is the item code again here we overwrite the previouse item code as a check in case the first time breaking off the code did not go as planed.
                            // also closes the information rows. 
                            refinedBody.Add(rawBody[i]);
                            refinedBody.Add(itemCode.ToArray()[i2]);
                            refinedBody.Add("<Warehouse code=" + '"' + "INDU" + '"' + " />");
                            refinedBody.Add("<Costcenter code=" + '"' + "2" + '"' + ">");
                            refinedBody.Add("</Costcenter>");
                            refinedBody.Add("</OrderLine>");
                        }

                        else
                        {
                            refinedBody.Add(rawBody[3]);
                            refinedBody.Add(itemCode.ToArray()[i2]);
                            refinedBody.Add("<Warehouse code=" + '"' + "INDU" + '"' + " />");
                            refinedBody.Add("<Costcenter code=" + '"' + "2" + '"' + ">");
                            refinedBody.Add("</Costcenter>");
                            refinedBody.Add("</OrderLine>");
                        }
                        i2++;
                    }
                    i++;
                }


                // this is for the sub lines part of the SNOWFLAKE-HANDLER STRUCTURE.
                while (isSubRegel == true)
                {
                    x = i % 4;

                    if (x == 0)
                    {
                        snowflakes.Add(rawBody[0 + i]);
                    }

                    if (x == 1)
                    {
                        if (i > 1)
                        {
                            snowflakes.Add(rawBody[2 + (i - 1)]);
                        }
                        else { snowflakes.Add(rawBody[2]); }
                    }

                    if (x == 2)
                    {
                        if (i > 2)
                        {
                            snowflakes.Add(rawBody[1 + (i - 2)]);
                        }
                        else { snowflakes.Add(rawBody[1]); }
                    }

                    if (x == 3)
                    {
                        if (i > 3)
                        {
                            snowflakes.Add(rawBody[i]);
                            snowflakes.Add(itemCode.ToArray()[i2]);
                            snowflakes.Add("<Warehouse code=" + '"' + "INDU" + '"' + " />");
                            snowflakes.Add("<Costcenter code=" + '"' + "2" + '"' + ">");
                            snowflakes.Add("</Costcenter>");
                            snowflakes.Add("</OrderLine>");

                        }

                        else
                        {
                            snowflakes.Add(rawBody[3]);
                            snowflakes.Add(itemCode.ToArray()[i2]);
                            snowflakes.Add("<Warehouse code=" + '"' + "INDU" + '"' + " />");
                            snowflakes.Add("<Costcenter code=" + '"' + "2" + '"' + ">");
                            snowflakes.Add("</Costcenter>");
                            snowflakes.Add("</OrderLine>");

                        }
                        isSubRegel = false;
                        i2++;
                    }
                    x = i % 4;
                    i++;
                }

            }
             return refinedBody;
        }

        // Writing the header of the xml file using file stream
        public bool WriteHeader()
        {
            sfd.Filter = "xml files files (*.xml)|*.xml";
            MessageBox.Show("Press OK to choese a path for the converted file to be saved to. Press Cancel in the selection menu to cancel the conversion.");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = File.Create(sfd.FileName))
                    {
                        foreach (var field in XmlHeader())
                        {
                            WriteLine(fs, field);
                            counter++;
                        }

                        fs.Flush();
                        fs.Dispose();
                        fs.Close();
                    }

                    MessageBox.Show("File is Converted!");
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    File.Delete(sfd.FileName);
                    
                }
            }
            return true;
        }

        public void BomToSql(string debnr, List<cicntp> cicntp ,List<cicmpy> cicmpy, string uwRef, string oms, DateTime dateTime)
        {
            // when the code enters this method firstly the method WriteHeader will be executed. Which means that alle the code above in this file will be executed firstly
            // and after that the code below. The code below converts all the lists that have been filled to arrays and adds extra data that could no be read from the xml file
            // such as dateTime class and the orderNr. 
            WriteHeader();

            //---------------------------------------------------------HEAD----------------------------------------------------------
            string debNr = debnr;
            byte orderAfdracht = 0;
            DateTime orderDate = dateTime;
            DateTime aflDate = dateTime; 
            byte orderbv_afgd = 0; 
            byte afgehandeld = 0;
            byte nettoPris = 0;
            byte inv_in_vv = 0;
            byte  betaald = 0;
            DateTime sysCreated = DateTime.Now;
            string docTitle = uwRef;
            //---------------------------------------------------------HEAD----------------------------------------------------------

            //---------------------------------------------------------BODY----------------------------------------------------------
            orkrgs = orderHeeaderController.GetAllOrderNr();

            foreach (var item in orkrgs)
            {
                if (item.ord_soort == "V")
                {
                    orderNrs.Add(item.ordernr);
                }
            }

            string[] aOrdNrs = orderNrs.ToArray();

            int ordersCount = aOrdNrs.Count();
            int iOrderNr = Convert.ToInt32(aOrdNrs[ordersCount -1 ]) + 1; 
            string orderNr = iOrderNr.ToString();

            string[] aRegel = regel.ToArray();                      // wordt gevuld
            DateTime afldat = new DateTime();
            afldat = dateTime;                                  // nullable
            string[] aArtCode = artCode.ToArray();
            string[] aOms45 = oms45.ToArray();
            string oms45_f = oms;              
            float magCode = 1;                                      // Altijd INDU
            float[] aEsr_Aantal = esr_aantal.ToArray();
            float[] aEsr_aantal2 = esr_aantal2.ToArray();
            string aBtw_code = "21"; 
            float aKorting = 0;
            int aSyscreator = 1; 

            float[] aCSRekRegelVal = CSRekRegelVal.ToArray();
            float[] aCSRekRegelVal2 = CSRekRegelVal2.ToArray();
            float[] aCSRekRegelVal3 = CSRekRegelVal3.ToArray();

            float CSFactor = 0;
            DateTime sysMod = new DateTime();                       // Altijd Vandaag
            float[] aCSRekRegelValPlaat = CSRekRegelValPlaat.ToArray();
            float[] aCSRekRegelVal2Plaat = CSRekRegelVal2Plaat.ToArray();
            sysMod = DateTime.Now;

            float[] aCsRekregValProfile = CSRekRegelValProfiel.ToArray();
            float[] aCsRekRegVal2Profile = CSRekRegelVal2Profiel.ToArray();
            float[] aCsRekregVal3Profile = CSRekRegelVal3Profiel.ToArray();

            float[] aCsRekRegValPlaat = CSRekRegelValPlaat.ToArray();
            float[] aCsRekRegVal2Plaat = CSRekRegelVal2Plaat.ToArray();
            float[] aCsRekReglVal3plaat = CSRekRegelVal3Plaat.ToArray();
            //---------------------------------------------------------BODY----------------------------------------------------------

            //---------------------------------------------------------SUB-REGEL----------------------------------------------------------

            string[] aSubRegel = snowflakeRgel.ToArray();
            string[] aSubArtCode = snowflakeArtCode.ToArray();
            string[] aSubOms45 = snowflakeOms45.ToArray();
            //---------------------------------------------------------SUB-REGEL----------------------------------------------------------

            //-------------------------------------------------------CHECK PARAMETERS-----------------------------------------------------
            int plaatCounter2 = 0;
            int p = 0;
            int pr = 0;
            int profReken = 0;
            int art = 0;
            int artcounter2 = aCSRekRegelVal.Count();
            int s = 0;
            List<string> regels = new List<string>();

            //-------------------------------------------------------CHECK PARAMETERS-----------------------------------------------------
            // CREATE HEADER
            Db.CreateOrderHeader(cicntp, cicmpy, debnr, orderAfdracht, orderNr, debnr, debnr, debnr, oms45_f, "17", orderbv_afgd, afgehandeld, nettoPris, inv_in_vv, betaald, orderDate, afldat, sysCreated, sysMod, docTitle);

            for (int a = 0; a <= regelCount; a++)
            {
                int record = 0;
                regels.Clear();
                foreach (var item in refinedBody)
                {

                    if (item.Contains("OrderLine lineNo"))
                    {
                        regels.Add(item);
                    }

                    if (item.Contains("Profile") && record == 0 && pr < profileCounter || item.Contains("profile") && record == 0 && pr < profileCounter)
                    {
                        if (aArtCode[a].Contains("/"))
                        {
                            profReken++;
                        }

                        if (regels.Last().Contains(".") && record == 0 && s < specialCounter)
                        {
                            Db.CreateSubLines(orderNr, aSubRegel[s], aSubArtCode[s], aSubOms45[s]);
                            s++;
                        }

                        else
                        {
                            Db.CreateOrderBodyProfiel(orderNr, aRegel[a], afldat, aArtCode[a], aOms45[a], oms45_f, "INDU", aEsr_aantal2[profReken - 1], aEsr_Aantal[a], aBtw_code,
                               aKorting, aSyscreator, aCsRekregValProfile[profReken - 1], aCsRekRegVal2Profile[profReken - 1], sysMod, sysMod);
                            pr++;
                        }
                        record++;
                    }

                    if (record == 0 && item.Contains("<Description>") && !item.Contains("SIZE:") && !item.Contains("Profile") && art < artcounter2 && !item.Contains("profile"))
                    {
                        if (regels.Last().Contains(".") && record == 0 && s < specialCounter)
                        {
                            Db.CreateSubLines(orderNr, aSubRegel[s], aSubArtCode[s], aSubOms45[s]);
                            s++;
                        }

                        else
                        {
                            Db.CreateOrderBodyACC(orderNr, aRegel[a], afldat, aArtCode[a], aOms45[a], oms45_f, "INDU", aEsr_Aantal[a],
                            aBtw_code, aKorting, aSyscreator, aCSRekRegelVal[art], sysMod, sysMod);
                            art++;
                        }
                        record++;
                    }

                    if (item.Contains("SIZE:") && record == 0 && p < plaatCounter)
                    {
                        if (regels.Last().Contains(".") && record == 0 && s < specialCounter)
                        {
                            Db.CreateSubLines(orderNr, aSubRegel[s], aSubArtCode[s], aSubOms45[s]);
                            s++;
                        }

                        else
                        {
                            Db.CreateOrderBodyPlaat(orderNr, aRegel[a], afldat, aArtCode[a], aOms45[a], oms45_f, "INDU", aEsr_aantal2[p], aEsr_Aantal[a], aBtw_code,
                            aKorting, aSyscreator, aCSRekRegelValPlaat[p], aCSRekRegelVal2Plaat[p], aCsRekReglVal3plaat[p], sysMod, sysMod);
                            plaatCounter2++;
                            p++;
                        }

                        // CREATE BODY
                        record++;
                    }
                }
            }

            for (int i = 0; i < specialCounter; i++)
            {
                Db.CreateSubLines(orderNr, aSubRegel[i], aSubArtCode[i], aSubOms45[i]);
            }

            Db.SaveOrder();
            MessageBox.Show("data is in db geggoid");
        }

        // Method to get the byte value from stream  input (must be string) e.g. the list of strings called XmlHeader
        private static void WriteLine(FileStream fs, string value)
        {
            // Converting string to byte array and writing the byte array to file. 
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}