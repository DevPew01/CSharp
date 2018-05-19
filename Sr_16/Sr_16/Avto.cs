using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_16
{
    // Потом доделаю!!!!!!!!!!!!!!!!!
    class Avto
    {
        public Avto()
        {
            Date = new DateTime(0001, 01, 01);
            Mark = null;
            Model = null;
            Price = 0;
        }
        public Avto(string mrk, string mld, DateTime dt, double prc)
        {
            Mark = mrk;
            Model = mld;
            Date = dt;
            Price = prc;
        }
        public string Mark { set; get; }
        public string Model { set; get; }
        public DateTime Date { set; get; }
        public double Price { set; get; }

        public override string ToString()
        {
            return $"Car brand: {Mark}\nModel: {Model}\nYear: {Date}\nPrice: {Price}";
        }
    }
}
