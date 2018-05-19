using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_9
{
    class Laptop
    {
        public Laptop(string name, double price)
        {
            Vendor = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Производитель: {Vendor}\nЦена: ${Price}";
        }
        public string Vendor { set; get; }
        public double Price { set; get; }
    }
}
