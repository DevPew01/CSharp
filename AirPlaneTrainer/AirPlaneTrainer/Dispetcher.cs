using System;

namespace AirPlaneTrainer
{
    class Dispatcher
    {
        public Dispatcher()
        {

        }
        public Dispatcher(string name)
        {
            Name = name;
            WeatherConditions = Weather.Next(-200, 200);
        }
        public string Name { set; get; }
        private int recommendedHeight;
        public int WeatherConditions { private set; get; }

        public Random Weather = new Random();

        public int Straf { set
            {
                straf = value;
                if (straf >= 1000)
                    throw new Exception("Unfit to fly!");
            }
            get
            {
                return straf;
            }
        }

        private void ReachedSpeedMessage()
        {
            Console.WriteLine("***************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Cruising speed achieved!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Start landing");
            Console.ResetColor();
        }

        private void OverSpeedMessage()
        {
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Over speed!!!\nDecrease speed!!!");
            Straf += 100;
            Console.ResetColor();
        }

        private void PlaneCrushedExeption(string message)
        {
            throw new Exception(message);
        }

        private void Recomend()
        {
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Recommended height: {recommendedHeight} (m)");
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Dispatcher {Name}, penalty {Straf}";
        }

        private int straf;
        public int TotalPenalty { set; get;  }
       
        public void OnChangeFlightParams(object sender, EventArgs e)
        {
            AirPlane plane = (AirPlane)sender;
            recommendedHeight = 7 * plane.Speed - WeatherConditions;
            int diffHeigth = Math.Abs(recommendedHeight - plane.Heigth);
            Recomend();
            if (plane.Speed == 1000)
                ReachedSpeedMessage();
            if (plane.OverSpeed)
                OverSpeedMessage();
            if (plane.Speed <= 0 || plane.Heigth <= 0||diffHeigth>1000)
                throw new Exception("Plane crushed!");
            if (diffHeigth >= 300 && diffHeigth <= 600)
                Straf += 25;
            if (diffHeigth >= 600 && diffHeigth <= 800)
                Straf += 50;
        }
    }
}
