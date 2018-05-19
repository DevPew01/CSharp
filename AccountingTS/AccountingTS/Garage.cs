using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountingTS
{
    public class Garage: IEnumerable
    {
        public Garage(int n)
        {
            CarArray = new Car[n];
        }
        public Garage() { }
        public int Length
        {
            get { return CarArray.Length; }
        }
        public Car this[int index]
        {
            set
            {
                if (index >= 0 && index < CarArray.Length)
                    CarArray[index] = value;
                else throw new IndexOutOfRangeException();
            }
            get
            {
                return CarArray[index];
            }
        }
        private Car[] CarArray;

        public IEnumerator GetEnumerator()
        {
            return CarArray.GetEnumerator();
        }

        public Car InitCar()
        {
            string model, mark;
            double price;
            CarColors colors = 0;
            string color;
            DateTime date;
            Console.WriteLine("Enter the car mark: ");
            mark = Console.ReadLine();
            Console.WriteLine("Enter the car model: ");
            model = Console.ReadLine();
            Console.WriteLine("Enter the car price: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the date of issue");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the car color: ");
            color = Console.ReadLine();
            for (int i = 0; i < color.Length; i++)
                if ((int)color[i] >= 41)
                    Convert.ToChar((int)color[i] - 32);
            switch (color)
            {
                case "red":
                    colors = CarColors.Red;
                    break;
                case "orange":
                    colors = CarColors.Orange;
                    break;
                case "yellow":
                    colors = CarColors.Yellow;
                    break;
                case "green":
                    colors = CarColors.Green;
                    break;
                case "ligthblue":
                    colors = CarColors.Ligth_Blue;
                    break;
                case "blue":
                    colors = CarColors.Blue;
                    break;
                case "purple":
                    colors = CarColors.Purple;
                    break;
            }
            return new Car(mark, model, colors, date, price);
        }

        public void SortByMark()
        {
            Array.Sort(CarArray, new CompareMark());
        }

        public void SortByModel()
        {
            Array.Sort(CarArray, new CompareModel());
        }

        public void SortByPrice()
        {
            Array.Sort(CarArray, new ComparePrice());
        }

        public void SortByColor()
        {
            Array.Sort(CarArray, new CompareColor());
        }

        public void SortByDate()
        {
            Array.Sort(CarArray, new CompareDate());
        }
    }
}