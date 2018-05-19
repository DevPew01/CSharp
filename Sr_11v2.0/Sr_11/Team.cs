using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_11
{
    class Team
    {
        public Team(int n)
        {
            workers = new IWorker[n + 1];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker($"Worker {i}");
            }
            workers[n] = new TeamLeader("Бригадир");
        }

        public void Built(House house)
        {
            int i = 0;
            while (!house.isBuild)
            {
                workers[i % workers.Length].Work(house);
                i++;
            }
        }
        IWorker[] workers;

        public int Length
        {
            get { return workers.Length; }
        }

    public IWorker this[int index]
        {
            set
            {
                if (index >= 0 && index < workers.Length)
                {
                    workers[index] = value;
                }
                else throw new IndexOutOfRangeException();
            }
            get
            {
                return workers[index];
            }
        }
    }
}
