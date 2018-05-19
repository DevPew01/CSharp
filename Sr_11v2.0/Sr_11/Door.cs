using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    class Door: IPart
    {
        public Door()
        {
            Name = "Дверь";
            isBuild = false;
        }
        public string Name { set; get; }

        public bool isBuild { set; get; }
    }
}
