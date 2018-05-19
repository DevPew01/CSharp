using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sr_16
{
    // Потом доделаю!!!!!!!!!!!!!!!!!
    class CompareMark<Avto> : IComparer
    {
        public int Compare(object x, object y)
        {
            Car car1 = (Car)x;
            Car car2 = (Car)y;
            if (car1.Mark == car2.Mark)
                return 0;
            else if (car1.Mark.Length > car2.Mark.Length)
                return 1;
            else return -1;
        }
    }

    class CompareModel : IComparer
    {
        public int Compare(object x, object y)
        {
            Car car1 = (Car)x;
            Car car2 = (Car)y;
            if (car1.Model == car2.Model)
                return 0;
            else if (car1.Model.Length > car2.Model.Length)
                return 1;
            else return -1;
        }
    }

    class CompareDate : IComparer
    {
        public int Compare(object x, object y)
        {
            Car car1 = (Car)x;
            Car car2 = (Car)y;
            if (car1.Date == car2.Date)
                return 0;
            else if (car1.Date > car2.Date)
                return 1;
            else return -1;
        }
    }

    class ComparePrice : IComparer
    {
        public int Compare(object x, object y)
        {
            Car car1 = (Car)x;
            Car car2 = (Car)y;
            if (car1.Price == car2.Price)
                return 0;
            else if (car1.Price > car2.Price)
                return 1;
            else return -1;
        }
    }
}
