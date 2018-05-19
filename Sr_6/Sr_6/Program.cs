using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(2, 2);
            Complex z1;
            z1 = z + (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
        }
    }
}
