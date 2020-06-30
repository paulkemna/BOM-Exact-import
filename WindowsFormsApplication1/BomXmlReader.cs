using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    // AT ALL TIMES YOU CAN PUT THE CURSOR ON THE CLASS OR METHOD THEN PRESS F12 TO GO TO THE CLASS-DECLARATION.

    // Class that reads a xml file that is inputed and returns the reqeured fields and their values to create a copatible xml file for exact.
    class BomXmlReader
    {
        int selectCount = 0;
        List<string> xmlElements = new List<string>();
        List<string> TagAndVal = new List<string>();
        List<string> ClosingTag = new List<string>();
        string[] aTagAndVal;
        string[] aClosingTag;
        string[] aVals;
        string value;
        string field;
        string xmlTag;
        int tagCounter = 0;
        int articleCounter = 1;
        int descriptionCounter = 1;
        int unitCounter = 1;
        int quantetyCounter = 1;
        int priceEachCounter = 1;
        int priceCount = 1;
        int categoryCounter = 1;
        string sFileName;
        List<string> FileNameList = new List<string>();
        List<string> formatedDigits = new List<string>();

        OpenFileDialog ofd = new OpenFileDialog();

        // selecting a file to convert and return the name of the file as string to be saved and displayed to the user in txtFiileName
        public string SelectFile()
        {
            MessageBox.Show("Press OK to select a BOM XML file to be read and converted to exact XML standarts. Press Cancel in the selection to cancee the prosedure.");
            ofd.Filter = "xml files files (*.xml)|*.xml";
          //  ofd.Multiselect = true; // mada mada...
            // Show file dialog to enable the user to select a file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileNameList.Add(fileName);
                }
                
            }
            else
            {
                MessageBox.Show("The conversion prosedure has been canceled. The selectd path and creeted file has been deleted!");

            }
            return sFileName;
        }

        // Method to check whether a number is odd 
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        // This method reads a xml file and returns the fields and  returns their values
        private List<string> GetXmlElemetns(string fileName)
        {

            using (XmlReader reader = XmlReader.Create(fileName))
            {
                reader.MoveToContent();

                while (!reader.EOF)
                {
                    reader.Read();
                    field = reader.LocalName.ToString();

                        switch (field)
                        {

                            case "tag":
                                if (!IsOdd(tagCounter))
                                {
                                    xmlTag = "<tag>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</tag>"; xmlElements.Add(xmlTag); }
                                tagCounter++;
                                break;

                            case "article":
                                if (IsOdd(articleCounter))
                                {
                                    xmlTag = "<article>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</article>"; xmlElements.Add(xmlTag); }
                                articleCounter++;
                                break;

                            case "description":
                                if (IsOdd(descriptionCounter))
                                {
                                    xmlTag = "<description>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</description>"; xmlElements.Add(xmlTag); }
                                descriptionCounter++;
                                break;

                            case "units":
                                if (IsOdd(unitCounter))
                                {
                                    xmlTag = "<units>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</units>"; xmlElements.Add(xmlTag); }
                                unitCounter++;
                                break;

                            case "quantity":
                                if (IsOdd(quantetyCounter))
                                {
                                    xmlTag = "<quantity>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</quantity>"; xmlElements.Add(xmlTag); }
                                quantetyCounter++;
                                break;

                            case "price":
                                if (IsOdd(priceCount))
                                {
                                    xmlTag = "<price>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</price>"; xmlElements.Add(xmlTag); }
                                priceCount++;
                                break;

                            case "category":
                                if (IsOdd(categoryCounter))
                                {
                                    xmlTag = "<category>";
                                    xmlElements.Add(xmlTag);
                                }
                                else { xmlTag = "</category>"; xmlElements.Add(xmlTag); }
                                categoryCounter++;
                                break;

                            default:
                                break;
                        }
                }
                reader.Dispose();
                reader.Close();
            }

            return xmlElements;
        }
        
        // This method gets the xml from the BOM and puts it raw into a string list as multiple strings string. Each element has its own string e.g. <tag>1</tag> is a seperate string from <artikle>product</artikle>.
        public List<string> 
            GetXml()
        {

            //if (selectCount != 1)
            //{
            //    
            //    selectCount++;
            //}

            SelectFile();
            List<string> xml = new List<string>();
            // needst to procs file f file, does not dothat therfore an array out of bounds excaption is created. 
            // needs to filter sub-rows 
            foreach (string fileName in FileNameList)
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    reader.MoveToContent();

                    int elementCounter = 1;
                    List<string> lVals = new List<string>();
                    List<string> lEle = new List<string>(GetXmlElemetns(fileName));
                    List<string> regels = new List<string>();

                    string[] aXmlelements = lEle.ToArray();
                    int eleCounter = 0;
                    int valCounter = 1;
                    int valCounter2 = 0;

                    int skip = 0;
                    while (!reader.EOF)
                    {
                        reader.Read();
                        value = reader.Value.ToString();
                        if (value != "" && skip == 0)
                        {
                            lVals.Add(value);
                        }
                        if (reader.LocalName == "price_each")
                        {
                            skip = 1;
                        }
                        else { skip = 0; }
                    }

                    aVals = lVals.ToArray();

                    for (int i = 0; i < aVals.Count(); i++)
                    {
                        int x = i % 7;
                        if (x == 0)
                        {
                            regels.Add(aVals[i]);
                        }
                    }

                    double lastRowDigits = Math.Floor(Math.Log10(Convert.ToDouble(regels.Last())));

                    switch (lastRowDigits)
                    {
                        case 1:

                            foreach (var sRegel in regels)
                            {
                                if (sRegel.Contains("."))
                                {
                                    string[] splitSrt = sRegel.Split('.');
                                    double digits = Math.Floor(Math.Log10(Convert.ToDouble(splitSrt[0])));
                                    if (digits < lastRowDigits)
                                    {
                                        formatedDigits.Add("0" + sRegel);
                                    }
                                }
                                else
                                {
                                    double digits = Math.Floor(Math.Log10(Convert.ToDouble(sRegel)));
                                    if (digits < lastRowDigits)
                                    {
                                        formatedDigits.Add("0" + sRegel);
                                    }
                                }
                            }
                            break;
                        case 2:

                            foreach (var sRegel in regels)
                            {
                                if (sRegel.Contains("."))
                                {
                                    string[] splitSrt = sRegel.Split('.');
                                    double digits = Math.Floor(Math.Log10(Convert.ToDouble(splitSrt[0])));

                                    double diference = lastRowDigits - digits;
                                    if (digits < lastRowDigits)
                                    {
                                        if (diference == 2)
                                        {
                                            formatedDigits.Add("00" + sRegel);
                                        }
                                        else
                                        {
                                            formatedDigits.Add("0" + sRegel);
                                        }
                                    }
                                }
                                else
                                {
                                    double digits = Math.Floor(Math.Log10(Convert.ToDouble(sRegel)));
                                    double diference = lastRowDigits - digits;
                                    if (digits < lastRowDigits)
                                    {
                                        if (diference == 2)
                                        {
                                            formatedDigits.Add("00" + sRegel);
                                        }
                                        else
                                        {
                                            formatedDigits.Add("0" + sRegel);
                                        }
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }

                    int r = 0;
                    foreach (var item in formatedDigits)
                    {
                        aVals[r] = item;
                        r = r + 7;
                    }

                    try
                    {
                        foreach (var element in lEle)
                        {
                            if (IsOdd(valCounter) && valCounter2 <= aVals.Count())
                            {
                                TagAndVal.Add(aXmlelements[eleCounter] + aVals[valCounter2]);
                                valCounter2++;
                            }
                            else { ClosingTag.Add(aXmlelements[eleCounter]); }
                            valCounter++;
                            eleCounter++;
                        }

                        aClosingTag = ClosingTag.ToArray();
                        aTagAndVal = TagAndVal.ToArray();
                        int iClosingTag = 0;
                        int iTagAndVal = 0;

                        foreach (var item in TagAndVal)
                        {
                            xml.Add(aTagAndVal[iTagAndVal] + aClosingTag[iClosingTag]);
                            iClosingTag++;
                            iTagAndVal++;
                            eleCounter++;
                        }
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                    reader.Dispose();
                    reader.Close();
                }
            }
            return xml;
        }
    }
}