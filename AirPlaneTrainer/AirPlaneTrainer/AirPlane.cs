using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPlaneTrainer
{
    class AirPlane
    {
        public event EventHandler OnFligh;
        private AirPlane()
        {
            speed = 0;
            heigth = 0;
        }
        private static AirPlane instance;
        public static AirPlane GetInstance()
        {
            if (instance == null)
                instance = new AirPlane();
            return instance;
        }
        private int speed;
        private int heigth;

        public int Heigth
        {
            set
            {
                heigth = value;
                if (speed > 50)
                    OnFligh?.Invoke(this, new EventArgs());
                if (heigth == 0 && MissionComplete)
                    IsLanding = true;
            }
            get { return heigth; }
        }

        public bool IsLanding { private set; get; }
        public bool MissionComplete { private set; get; }
        public bool OverSpeed { private set; get; }

        public int Speed
        {
            set
            {
                speed = value;
                if (speed > 50)
                    OnFligh?.Invoke(this, new EventArgs());
                    if (speed == 1000)
                        MissionComplete = true;
                    if (speed > 1000)
                        OverSpeed = true;
            }
            get { return speed; }
        }
        private ConsoleKeyInfo keyInfo;
        public void PlaneControl()
        {
            keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Modifiers)
            {
                case ConsoleModifiers.Shift & ConsoleModifiers.Control:
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                        Speed -= 50;
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                        Speed += 50;
                    Console.WriteLine($"Current speed: {Speed} km/h");
                    break;
                case ConsoleModifiers.Shift:
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                        Speed -= 150;
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                        Speed += 150;
                    Console.WriteLine($"Current speed: {Speed} km/h");
                    break;
                case ConsoleModifiers.Alt:
                    Console.WriteLine("Enter the name of the dispatcher for adding:");
                    string Src_name = Console.ReadLine();
                    AddDispatcher(new Dispatcher(Src_name));
                    Console.WriteLine("Dispacher added!");
                    break;
            }
            switch (keyInfo.Modifiers)
            {
                case ConsoleModifiers.Shift & ConsoleModifiers.Control:
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                        Heigth += 250;
                    else if (keyInfo.Key == ConsoleKey.DownArrow)
                        Heigth -= 250;
                    Console.WriteLine($"Current heigth: {heigth} m");
                    break;
                case ConsoleModifiers.Shift:
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                        Heigth += 500;
                    else if (keyInfo.Key == ConsoleKey.DownArrow)
                        Heigth -= 500;
                    Console.WriteLine($"Current heigth: {heigth} m");
                    break;
                case ConsoleModifiers.Control:
                    if (Count > 2)
                    {
                        Console.WriteLine("Enter the name of the dispatcher for removing:");
                        string Src_name = Console.ReadLine();
                        DeleteDispatcher(Src_name);
                        Console.WriteLine("Dispather deleted!");
                    }
                    else Console.WriteLine("You can not delete the dispatcher!");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Dispatcher disp in dispatchers)
                Console.WriteLine(disp);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ctrl+ - remove");
            Console.WriteLine("Alt+ - add");
            Console.WriteLine("Climb - Up arrow;");
            Console.WriteLine("Decline - Down arrow;");
            Console.WriteLine("Speed Up - Rigth arrow;");
            Console.WriteLine("Speed Down - Left arrow");
            Console.ResetColor();
        }
        public int Count { get { return dispatchers.Count; } }
        public void AddDispatcher(Dispatcher dispatcher)
        {
            OnFligh += dispatcher.OnChangeFlightParams;
            dispatchers.Add(dispatcher);
        }

        public bool StartFligth()
        {
            if (dispatchers.Count < 2)
            {
                Console.WriteLine("Add a dispatcher!");
                return false;
            }
            else
            {
                Console.WriteLine("Takeoff is allowed!");
                return true;
            }
        }
        private List<Dispatcher> dispatchers = new List<Dispatcher>();
        public int RemPen { set; get; }
        public void DeleteDispatcher(string name)
        {
            for (int i = 0; i < dispatchers.Count; i++)
                if (dispatchers[i].Name.Equals(name))
                {
                    RemPen = dispatchers[i].Straf;
                    OnFligh -= dispatchers[i].OnChangeFlightParams;
                    dispatchers.RemoveAt(i);
                    break;
                }
        }

        private int TotalPenalty;
        public void SuccsessEndOfFly()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The plane landed successfully");
            foreach (Dispatcher disp in AirPlane.GetInstance().dispatchers)
            {
                TotalPenalty += disp.Straf;
                Console.WriteLine(disp);
            }
            TotalPenalty += RemPen;
            Console.WriteLine($"Total fine:{TotalPenalty}");
        }

    }
}
