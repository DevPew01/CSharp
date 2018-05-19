using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    public interface IWorker
    {
        string Position { set; get; }
        void Work(House house);
    }

    class Worker : IWorker
    {
        public string Name { get; set; }
        public Worker(string name)
        {
            Name = name;
            Position = "рабочий";
        }
        public string Position { get; set; }

        public void Work(House house)
        {
            for (int i = 0; i < house.Length; i++)
                if (!house[i].isBuild)
                {
                    house[i].isBuild = true;
                    Console.WriteLine($"Привет я {Position}, часть {house[i].Name} построена");
                    break;
                }
        }
    }
}