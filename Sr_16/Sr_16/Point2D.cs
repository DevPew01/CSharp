using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_16
{
    // Потом доделаю!!!!!!!!!!!!!!!!!
    class Point2D<T>
    {
        public T X { set; get; }
        public T Y { set; get; }

        public Point2D(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"Точка X - {X}, точка Y - {Y}";
        }
    }
}
