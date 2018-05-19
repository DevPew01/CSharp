using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    public interface IPart
    {
        string Name { set; get; }
        bool isBuild { set; get; }
    }

    public class House
    {
        IPart[] parts = new IPart[10];

        public House()
        {
            parts[0] = new Basement();
            for (int i = 1; i < 5; i++)
                parts[i] = new Walls();
            parts[5] = new Roof();
            parts[6] = new Window();
            parts[7] = new Window();
            parts[8] = new Door();
            parts[9] = new Door();
        }

        public int Length
        {
            get { return parts.Length; }
        }

        public IPart this[int index]
        {
            set
            {
                if (index >= 0 && index < parts.Length)
                {
                    parts[index] = value;
                }
                else throw new IndexOutOfRangeException();
            }
            get
            {
                return parts[index];
            }
        }
        public bool isBuild{ set; get; }
    }
}