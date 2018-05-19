using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team(5);
            team.Built(house);
            
        }
    }
}