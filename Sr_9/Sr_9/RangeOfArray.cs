using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_9
{
    class RangeOfArray
    {
        private int minRange;
        private int maxRange;

        private int[] Arr;

        public RangeOfArray(int min, int max)
        {
            minRange = min;
            maxRange = max;
            Arr = new int[max - min + 1];
        }

        public int Lenght
        {
            get { return Arr.Length; }
        }

        public int this[int index]
        {
            set
            {
                if (index > minRange || index < maxRange)
                {
                    Arr[index - minRange] = value;
                }
                else throw new IndexOutOfRangeException();
            }
            get { return Arr[index - minRange]; }
        }
    }
}
