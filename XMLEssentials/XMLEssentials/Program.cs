using System;
using System.Xml;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

namespace XMLEssentials
{
    enum Cityes {Almata = 36870, Astana = 35188, Ashhabad = 38880, Baku = 37850, Vilnius = 26730, Dushambe = 38836, Yerevan = 37789, Kyev = 33345, Minsk = 26850, Ryga = 26422, Tallin = 38457, Tashkent = 37549, Kyzyl = 36096, Magadan = 25913};

    class Program
    {

        static Dictionary<string, Cityes> CreateCollection()
        {
            Dictionary<string, Cityes> dictionary = new Dictionary<string, Cityes>();
            dictionary.Add("Алмата", Cityes.Almata);
            dictionary.Add("Ашхабад", Cityes.Ashhabad);
            dictionary.Add("Астана", Cityes.Astana);
            dictionary.Add("Баку", Cityes.Baku);
            dictionary.Add("Вильниус", Cityes.Vilnius);
            dictionary.Add("Душанбе", Cityes.Dushambe);
            dictionary.Add("Ереван", Cityes.Yerevan);
            dictionary.Add("Киев", Cityes.Kyev);
            dictionary.Add("Минск", Cityes.Minsk);
            dictionary.Add("Рига", Cityes.Ryga);
            dictionary.Add("Талин", Cityes.Tallin);
            dictionary.Add("Ташкент", Cityes.Tashkent);
            dictionary.Add("Магадан", Cityes.Magadan);
            dictionary.Add("Кызыл", Cityes.Kyzyl);
            return dictionary;
        }

        static void Main(string[] args)
        {


            Dictionary<Cityes, double> CityTemp = new Dictionary<Cityes, double>();
            //Console.WriteLine();
            //foreach (var item in CreateCollection())
            //{
            //    Console.WriteLine($"Город: {item.Key} Код:{(int)item.Value}");
            //}
            foreach(KeyValuePair<string, Cityes> it in CreateCollection())
            {
                KeyValuePair<Cityes, double> pair = GetTemp(it.Value);
                CityTemp.Add(pair.Key, pair.Value);
            }
           
        }

        static KeyValuePair<Cityes, double> GetTemp(Cityes city)
        {
            string url = $"http://informer.gismeteo.by/rss/{(int)city}.xml";
            XmlDocument document = new XmlDocument();
            document.Load(url);
            XmlElement root = document.DocumentElement;
            string City, temp = null;
            double avg = 0;
            foreach (XmlNode node in root.SelectNodes(@"/rss/channel/item"))
            {
                City = node.SelectSingleNode("title").InnerText;
                temp = node.SelectSingleNode("description").InnerText;
                Console.WriteLine($"Город: {City}, {temp}");
                Regex regex = new Regex(@"[+-]?\d+..[+-]?\d+\s+С");
                temp = regex.Match(temp).Value;
                Regex regex1 = new Regex(@"\s+С");
                temp = regex1.Replace(temp, "");
                string[] NewTemp = Regex.Split(temp, @"[.]+");
                foreach (string st in NewTemp)
                {
                    avg += Convert.ToDouble(st);
                }
                avg /= NewTemp.Length;
                break;
            }
            return new KeyValuePair<Cityes, double>(city, avg);
        }
    }
}