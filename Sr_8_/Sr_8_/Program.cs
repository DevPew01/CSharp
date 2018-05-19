using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(0, 1);
            Fraction fraction = new Fraction(2, 0);
            Fraction fraction2 = new Fraction(4, 5);
            Fraction result = new Fraction();
            Fraction fraction1 = new Fraction(2, 5);
            try
            {
                money--;
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Exept);
            }

            try
            {
                result = fraction + fraction1;
                result = fraction2 - fraction1;
                result = fraction * fraction1;
                result = fraction / fraction1;
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Exept);
            }
        }
    }
}
