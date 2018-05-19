using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_16
{
    // Потом доделаю!!!!!!!!!!!!!!!!!
    class Program
    {
        static void Main(string[] args)
        {
            Point2D<int> point = new Point2D<int>(10, 18);
            Console.WriteLine(point);
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine("Это точка -> *");
            Console.ReadKey();


        }
    }
}
