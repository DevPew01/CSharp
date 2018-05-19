using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_10
{
    class Program
    {
        static double AllCap(Flash flash, HDD hDD, DVD dVD)
        {
            return (flash.GetCapacity() + hDD.GetCapacity() + dVD.GetCapacity()) * 1024;
        }

        static void Copy()
        {

        }
        static void Main(string[] args)
        {
            Flash flash = new Flash("Kingston", "F", 32, 345);
            Console.WriteLine(flash);
            DVD dvd = new DVD("Disc", "mVideo", 1.32f, 4.7f)
            {
                SideType = true
            };
            Console.WriteLine("\n{0}", dvd);
            HDD hdd = new HDD("Seagate", "Iron wolf", 120, 3, 40*1024, 453);
            Console.WriteLine("\n{0}", hdd);

            Console.WriteLine();
            Console.WriteLine($"All capacity: {AllCap(flash, hdd, dvd)} (Mb)");

            if (flash.Copy(780 / 1024) && dvd.Copy(780 / 1024) && hdd.Copy(780 / 1024))
                Console.WriteLine("Succsessfully copyed");
            int counter = 0;
            double size = AllCap(flash, hdd, dvd);
            while (size > 0)
            {
                counter++;
                size -= 780;
            }
            Console.Write(counter);
        }
    }
}
