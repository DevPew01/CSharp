using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_14
{
    public delegate void SpeedHandler(object sender, EventArgs args);

    class Car
    {
        public Car()
        {
            CurrentSpeed = 0;
        }
        public event SpeedHandler MaxSpeed; 

        private const double SpeedLimit = 250;

        private double CurrentSpeed { set; get; }

        public void UpSpeed(double speed)
        {
            CurrentSpeed += speed;
            Console.WriteLine(CurrentSpeed);
            if (CurrentSpeed > SpeedLimit)
                MaxSpeed(this, new EventArgs());
        }

        public void LowSpeed(double speed)
        {
            CurrentSpeed -= speed;
            Console.WriteLine(CurrentSpeed);
            if (CurrentSpeed < SpeedLimit / 2)
                Console.WriteLine("Давай быстрей!");
            else if (CurrentSpeed == 0)
            {
                Console.WriteLine("Не стой!");
                CurrentSpeed = 0;
            }
        }

        public void Move(Car car)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Modifiers)
                {
                    case ConsoleModifiers.Control:
                        if (keyInfo.Key == ConsoleKey.RightArrow)
                            car.UpSpeed(10);
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                            car.LowSpeed(10);
                        break;
                    case ConsoleModifiers.Control| ConsoleModifiers.Alt:
                        if (keyInfo.Key == ConsoleKey.RightArrow)
                            car.UpSpeed(10);
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                            car.LowSpeed(10);
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
 