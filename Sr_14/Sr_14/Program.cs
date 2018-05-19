using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.MaxSpeed += OnMaxSpeed;
           
            
            car.Move(car);
        }

        public static void OnMaxSpeed(object sender, EventArgs args)
        {
            Console.WriteLine("Превышение скорости!");
        }
    }
}
