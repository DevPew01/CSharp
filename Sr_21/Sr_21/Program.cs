using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Sr_21
{
    class Program
    {
        private static void DateFormatting(string date)
        {
            Console.WriteLine(date);
        }

        static void Main(string[] args)
        {
            FileStream file = new FileStream("Tovar.txt", FileMode.OpenOrCreate);
            using (StreamReader reader = new StreamReader(file, Encoding.Default))
            {
                string buff = reader.ReadToEnd();
                string patt = @"[,]\s+";
                Regex regex = new Regex(patt);
                string[] arr = regex.Split(buff);
                Regex regex1 = new Regex(@"\d+[.]?\d*");
                double sum = 0.0;

                foreach (Match it in regex1.Matches(buff))
                    sum += Double.Parse(it.Value);
                    Console.WriteLine($"Сумма - {sum} грн.");
                Dictionary<string, double> dict = new Dictionary<string, double>();

                foreach (string item in arr)
                       dict.Add(Regex.Match(item, @"^\w+").ToString(), Convert.ToDouble(regex1.Match(buff).Value));

                using (XmlTextWriter writer = new XmlTextWriter("tovar.xml", Encoding.Default))
                {
                    writer.Formatting = Formatting.Indented;
                    foreach (var it in dict)
                    {
                        writer.WriteStartElement("Товар");
                        writer.WriteElementString("Заказ", it.Key);
                        writer.WriteElementString("Цена", it.Value.ToString());
                        writer.WriteEndElement();
                    }
                }
            }
            string str = DateTime.Today.ToString(DateTimeFormatInfo.InvariantInfo);
            DateFormatting(str);
        }
    }
}
