using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("D://1.xml");
            XElement ele = doc.Element("book");
            var book = from i in ele.Elements()
                       select i;
            foreach (var item in book)
            {
                if (item.Name=="ID")
                {
                    item.Attribute("k").SetValue("JSJ");
                    Console.WriteLine(item.Attribute("k").Value);
                }
            }
            doc.Save("D://1.xml");
            Console.Read();
        }
    }
}
