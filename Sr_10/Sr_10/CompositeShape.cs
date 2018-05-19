using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_10
{
    public class CompositeShape: IEnumerable
    {
        private Shape[] FigureArr;

        public CompositeShape(int size)
        {
            FigureArr = new Shape[size];
        }

        public Shape this[int index] { 
            set
            {
                if (index > 0 && index < FigureArr.Length)
                {
                    FigureArr[index] = value;
                }
                else throw new IndexOutOfRangeException();
            }
            get
            {
                return FigureArr[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return FigureArr.GetEnumerator();
        }
    }
}
