using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void WordCounter(Dictionary<string, int> dictionary, string[] arr)
        {
            int counter = 0;
            foreach (string item in arr)
                if (dictionary.Keys.Contains(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, counter);
                }
        }

        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            string[] arr = text.Split(" .,!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, int>();
            WordCounter(dictionary, arr);
            int i = 0;
            foreach (KeyValuePair<string, int> item in dictionary)
            {
                ++i;
                //Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine($"{i, 2} {item.Key, 15} {item.Value + 1, 10}");
            }

            var list = new List<int>(10);
            for (int j = 0; j < list.Count; j++)
                list.Add(j + 2);
            IEnumerator<int> enumerable = list.GetEnumerator();
            while (enumerable.MoveNext())
                Console.WriteLine(enumerable.Current);
        }
    }
}