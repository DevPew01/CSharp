using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_9
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray rangeOfArray = new RangeOfArray(-1, 4);
            Shop shop = new Shop();
            try
            {
                shop[0] = new Laptop("Apple", 856);
                shop[1] = new Laptop("Asus", 567);
                shop[2] = new Laptop("HP", 658);
               foreach (Laptop item in shop)
                    Console.WriteLine(item);
            }
            catch(IndexOutOfRangeException exept)
            {
                Console.WriteLine(exept.Message);
            }
            Random rnd = new Random();
            try
            {
                Console.WriteLine("Пользовательський массив:");
                for (int i = -1; i < 4; i++)
                {
                    rangeOfArray[i] = rnd.Next(0, 20);
                    Console.Write(" {0}", rangeOfArray[i]);
                }
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException exept)
            {
                Console.WriteLine(exept.Message);
            }
        }
    }
}
