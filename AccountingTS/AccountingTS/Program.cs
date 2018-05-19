using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountingTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cars:");
            int count = Convert.ToInt32(Console.ReadLine());
            Garage garage = new Garage(count);
            for (int i = 0; i < garage.Length; i++) 
            {
                Console.Write($"{i + 1}) ");
                garage[i] = garage.InitCar();
            }
            Console.Clear();

            foreach (Car item in garage)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            garage.SortByModel();
            garage.SortByMark();
            garage.SortByDate();
            garage.SortByPrice();
            garage.SortByColor();

            foreach (Car item in garage)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
