using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine("Дробь 1: {0}", f1.ToString());
            Console.WriteLine("Дробь 2: {0}", f2.ToString());
            Console.WriteLine("Дробь 3: {0}", f3.ToString());

            Counter counter = new Counter { Seconds = 3675 };
            Timer timer = (Timer)counter;
            Console.WriteLine(timer);
            counter = (Counter)timer;
            Console.WriteLine(counter.ToString());
        }
    }
}
