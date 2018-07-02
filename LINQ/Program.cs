using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XNamespace empNM = "urn:lst-emp:emp";

            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating an XML tree using LINQ to XML 2"),
                new XElement("PurchaseOrder",
                    new XElement("Address", new XAttribute("Type", "Shipping"),
                        new XElement("Name", "Ellen Adams"),
                        new XElement("Street", "123 Maple Street"),
                        new XElement("City", "Mill Valley"),
                        new XElement("State", "CA"),
                        new XElement("Zip", "10999"),
                        new XElement("Country", "USA")),
                    new XElement("Address", new XAttribute("Type", "Billing"),
                        new XElement("Name", "Tai Yee"),
                        new XElement("Street", "8 Oak Avenue"),
                        new XElement("City", "Old Town"),
                        new XElement("State", "PA"),
                        new XElement("Zip", "95819"),
                        new XElement("Country", "USA"))));

            StringWriter sw = new StringWriter();
            XmlWriter xWrite = XmlWriter.Create(sw);
            xmlDocument.Save(xWrite);
            xWrite.Close();

            // Save to Disk
            xmlDocument.Save("linq.xml");
            Console.WriteLine("Saved");
        }
    }
}
