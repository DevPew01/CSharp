using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_10
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeShape composite = new CompositeShape(5);

            composite[1] = new Rectangle(3, 6);
            composite[2] = new Circle(2);
            composite[3] = new Triangle(3, 2, 7);
            composite[4] = new Square(4);

            foreach (Shape item in composite)
            {
                Console.WriteLine(item);
            }
        }
    }
}
