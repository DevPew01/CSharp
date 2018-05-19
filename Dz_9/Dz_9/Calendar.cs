using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_9
{
    class Calendar : IEnumerable
    {
        public Calendar(int min, int max)
        {
            this.max = max;
            this.min = min;
            MonthNum = new string[max - min + 1];
        }
        public string this[int index]
        {
            set
            {
                if (index > min || index < max)
                {
                    MonthNum[index - min] = value;
                }
                else throw new IndexOutOfRangeException();
            }
            get
            {
                return MonthNum[index - min];
            }
        }

        public int Length
        {
            get { return MonthNum.Length; }
        }

        private string[] MonthNum;
        public override string ToString()
        {
            return $"Month: {MonthNum}";
        }

        public IEnumerator GetEnumerator()
        {
            return MonthNum.GetEnumerator();
        }

        private int min, max;
    }
}
