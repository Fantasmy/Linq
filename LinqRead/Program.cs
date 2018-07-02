using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // read xml with linq

            XDocument xlmDocument = XDocument.Load("linq.xml");
            IEnumerable<XElement> PurchaseOrder = xlmDocument.Elements();
            foreach (var Address in PurchaseOrder)
            {
                Console.WriteLine(Address);
            }
        }
    }
}
