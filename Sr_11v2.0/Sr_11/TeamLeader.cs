using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    public class TeamLeader : IWorker
    {
        public string Name { set; get; }

        public TeamLeader(string name)
        {
            Name = name;
            Position = "Бригадир";
        }
        public string Position { get; set; }

        public void Work(House house)
        {
  
            for (int i = 0; i < house.Length; i++)
                if (!house[i].isBuild)
                {
                    house[i].isBuild = true;
                    Console.WriteLine($"Привет я {Position} проверил, что часть {house[i].Name} построена");
                    break;
                }
        }
    }
}
