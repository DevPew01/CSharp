using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    class Walls: IPart
    {
        public Walls()
        {
            Name = "стена";
            isBuild = false;
        }
        public string Name { set; get; }

        public bool isBuild { set; get; }
    }
}
