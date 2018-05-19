using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountingTS
{
    public class Car
    {
        public Car()
        {
            Color = 0;
            Date = new DateTime(0001, 01, 01);
            Mark = null;
            Model = null;
            Price = 0;
        }
        public Car(string mrk, string mld, CarColors clr, DateTime dt, double prc)
        {
            Color = clr;
            Mark = mrk;
            Model = mld;
            Date = dt;
            Price = prc;
        }
        public string Mark { set; get; }
        public string Model { set; get; }
        public CarColors Color { set; get; }
        public DateTime Date { set; get; }
        public double Price { set; get; }

        public override string ToString()
        {
            return $"Car brand: {Mark}\nModel: {Model}\nColor: {Color}\nYear: {Date}\nPrice: {Price}";
        }
    }
}
