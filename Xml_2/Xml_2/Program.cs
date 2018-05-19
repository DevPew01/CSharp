using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Xml_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"http://resources.finance.ua/ua/public/currency-cash.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("/source/organizations/organization");
                foreach (XmlNode node in childnodes)
                {
                    Console.WriteLine(node.SelectSingleNode("title/@value").Value);
                    XmlNode cur = node?.SelectSingleNode("currencies/c[@id ='USD']");
                    Console.WriteLine(cur?.SelectSingleNode("@br").Value);
                    Console.WriteLine(cur?.SelectSingleNode("@ar").Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}