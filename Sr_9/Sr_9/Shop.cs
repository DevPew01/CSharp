using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_9
{
    class Shop: IEnumerable
    {
        Laptop[] laptops = new Laptop[5];

        public int Lenght
        {
            get { return laptops.Length; }
        }

        public object Current => throw new NotImplementedException();

        public Laptop this[int index]
        {
            set
            {
                if (index > 0 || index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else throw new IndexOutOfRangeException();
            }
            get
            {
                return laptops[index];
            }
        }

        private int FindByVendor(string vendor)
        {
            for (int i = 0; i < laptops.Length; i++)
                if (laptops[i].Vendor == vendor)
                    return i;
            return -1;
        }

        private int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
                if (laptops[i].Price == price)
                    return i;
            return -1;
        }

        public IEnumerator GetEnumerator()
        {
            return laptops.GetEnumerator();
        }

        public Laptop this[string vendor]
        {
            get
            {
                if (FindByVendor(vendor) > -1)
                {
                    return laptops[FindByVendor(vendor)];
                }
                else throw new IndexOutOfRangeException();
            }
        }

        public Laptop this[double price]
        {
            get
            {
                if (FindByPrice(price) > -1)
                {
                    return laptops[FindByPrice(price)];
                }
                else throw new IndexOutOfRangeException();
            }
        }
    }
}
