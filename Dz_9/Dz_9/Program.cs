using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int ind;
            Calendar calendar = new Calendar(1, 12);
            try
            {
                calendar[1] = "January";
                calendar[2] = "February";
                calendar[3] = "March";
                calendar[4] = "April";
                calendar[5] = "May";
                calendar[6] = "June";
                calendar[7] = "July";
                calendar[8] = "August";
                calendar[9] = "September";
                calendar[10] = "October";
                calendar[11] = "November";
                calendar[12] = "December";
                //foreach (string item in calendar)
                //{
                //    Console.WriteLine(item);
                //}
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Enter the month number");
                    ind = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(calendar[ind]);
                    Console.WriteLine($"For continue press - 0");
                    exit = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                }
            }
            catch(IndexOutOfRangeException exept)
            {
                Console.WriteLine(exept.Message);
                Console.WriteLine(exept.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
